import { http } from '../api/config'

export default {
  // Obtem as Tribos
  obterTribo: () => {
    return http.get('Tribos')
  },
  obterTriboId: (id) => {
    return http.get('Tribos/:' + id)
  },
  // Altera as info da Tribo
  alterarTribo: () => {
    return http.put('Tribos')
  },
  // Inseri novas Tribos
  inserirTribo: () => {
    return http.post('Tribos')
  },
  // Altera o status, ativando e desativando as Tribos
  desativarTribo: () => {
    return http.patch('Tribos')
  }
}
