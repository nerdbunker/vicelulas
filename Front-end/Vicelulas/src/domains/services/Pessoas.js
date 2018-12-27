import { http } from '../api/config'

export default {
  // Obtem as Pessoas por: Todas, ID, ID da Squad
  obterPessoa: () => {
    return http.get('Pessoa')
  },
  obterPessoaPorId: (id) => {
    return http.get('Pessoa/' + id)
  },
  obterPessoaPorIdSquad: (id) => {
    return http.get('Pessoa/Squad/' + id)
  },
  // Get assincrono
  // obterPessoaAssinc: () => {
  //   return async => http.get('Pessoas')
  // },
  // Altera as info da Pessoa
  alterarPessoa: () => {
    return http.put('Pessoa')
  },
  // Insere novas Pessoas
  inserirPessoa: () => {
    return http.post('Pessoa')
  },
  // Altera o status, ativando/desativando as Pessoas
  desativarPessoa: () => {
    return http.patch('Pessoa')
  }
}
