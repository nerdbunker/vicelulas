import { http } from '../api/config'

export default {
  papeis: () => {
    return http.get('Papel')
  }
}
