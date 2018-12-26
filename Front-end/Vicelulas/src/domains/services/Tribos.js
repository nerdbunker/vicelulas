import { http } from '../api/config'

export default {
  // Obtem as Tribos
  obterTribo: () => {
    return http.get('Tribo')
  },
  obterTriboId: (id) => {
    return http.get('Tribo/' + id)
  },
  // Altera as info da Tribo
  alterarTribo: () => {
    return http.put('Tribo')
  },
  // Inseri novas Tribos
  inserirTribo: () => {
    return http.post('Tribo')
  },
  // Altera o status, ativando e desativando as Tribos
  desativarTribo: () => {
    return http.patch('Tribo')
  }
}
