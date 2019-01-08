import { http } from '../api/config'

export default {
  // Obtem as Pessoas por: Todas, ID, ID da Squad
  obterPessoa: () => {
    console.log('Obtive');
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
    return http.post('Pessoa', Pessoa)
  },
  // Altera o status, ativando/desativando as Pessoas
  mudarAtivoPessoa: (id) => {
    console.log('Fiz');
    return http.put('Pessoa/MudarAtivo/' + id)
  }
}
