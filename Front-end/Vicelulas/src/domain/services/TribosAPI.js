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
  alterarTribo: (id, tribo) => {
    return http.put('Tribo/' + id, tribo)
  },
  // Inseri novas Tribos
  inserirTribo: (Tribo) => {
    return http.post('Tribo', Tribo)
  },
  // Altera o status, ativando e desativando as Tribos
  mudarAtivoTribo: (id) => {
    return http.put('Tribo/MudarAtivo/' + id)
  }
}
