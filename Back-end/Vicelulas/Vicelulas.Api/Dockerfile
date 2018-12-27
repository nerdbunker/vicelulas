FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Vicelulas.Api/Vicelulas.Api.csproj", "Vicelulas.Api/"]
RUN dotnet restore "Vicelulas.Api/Vicelulas.Api.csproj"
COPY . .
WORKDIR "/src/Vicelulas.Api"
RUN dotnet build "Vicelulas.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Vicelulas.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Vicelulas.Api.dll"]