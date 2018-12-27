// Conexão de API para Login (chamado de 'Entrar' aqui neste sistema)

import { http } from '../api/config'

export default {
  entrar: () => {
    return http.get('Entrar')
  }
}
