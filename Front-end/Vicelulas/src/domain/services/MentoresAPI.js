import { http } from '../api/config'

export default {
  obterMentores () {
    return http.get('Mentor')
  }
}
