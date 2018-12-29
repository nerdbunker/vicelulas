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
  // Altera as info da Pessoa
  alterarPessoa: (id, Pessoa) => {
    return http.put('Pessoa/' + id, Pessoa)
  },
  // Insere novas Pessoas
  inserirPessoa: (Pessoa) => {
    return http.post('Cadastrar', Pessoa)
  },
  // Altera o status, ativando/desativando as Pessoas
  mudarAtivoPessoa: (id) => {
    return http.put('Pessoa/MudarAtivo/' + id)
  }
}
