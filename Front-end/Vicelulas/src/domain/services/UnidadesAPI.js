import { http } from '../api/config'

export default {
  unidades: () => {
    return http.get('Unidade')
  }
}
