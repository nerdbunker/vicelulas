import { http } from '../api/config'

export default {
  listarTribos: () => {
    return http.get('Tribos')
  }
}
