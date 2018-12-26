using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Viceluas.Dominio.Exceções;

namespace Fatec.Clinica.Api.Filtros
{
    public class ErroFiltro
    {
        private readonly RequestDelegate next;

        public ErroFiltro(RequestDelegate next)
        {
           this.next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode code;

            switch (exception)
            {
                case NaoEncontradoException nfEx:
                    code = HttpStatusCode.NotFound;
                    break;
                case ConflitoException nfEx:
                    code = HttpStatusCode.Conflict;
                    break;
                case RecusadoException nfEx:
                    code = HttpStatusCode.Forbidden;
                    break;
                default:
                    code = HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonConvert.SerializeObject(new { error = exception.Message, inner = exception.InnerException });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}

