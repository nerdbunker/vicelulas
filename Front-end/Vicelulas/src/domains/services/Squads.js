import { http } from '../api/config'

export default {
  listarSquads: () => {
    return http.get('Squads')
  }
}
