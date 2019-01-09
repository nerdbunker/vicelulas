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
    return http.get('Squad/Tribo/' + id)
  },
  // Altera as info da Squad
  alterarSquad: (id, squad) => {
    return http.put('Squad/' + id, squad)
  },
  // Inseri novas Squads
  inserirSquad: (Squad) => {
    return http.post('Squad', Squad)
  },
  // Altera o status, ativando e desativando as Squads
  desativarSquad: () => {
    return http.patch('Squad')
  }
}
