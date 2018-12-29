import { http } from '../api/config'

export default {
  // Obtem as Tribos
  obterSquad: () => {
    return http.get('Squad')
  },
  obterSquadPorId: (id) => {
    return http.get('Squad/' + id)
  },
  obterSquadPorIdTribo: (id) => {
    return http.get('Squad/tribo/' + id)
  },
  // Altera as info da Squad
  alterarSquad: () => {
    return http.put('Squad')
  },
  // Inseri novas Squads
  inserirSquad: () => {
    return http.post('Squad')
  },
  // Altera o status, ativando e desativando as Squads
  desativarSquad: () => {
    return http.patch('Squad')
  }
}
