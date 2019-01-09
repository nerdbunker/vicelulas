import { http } from '../api/config'

export default {
  // Obtem as Pessoas por: Todas, ID, ID da Squad
  obterPapel: () => {
    return http.get('Papel')
  }
}
