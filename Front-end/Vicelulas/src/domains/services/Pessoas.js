// id, id_papel, nome, email, cargo, ativo, id_Pessoa, id_unidade, permissao
import { http } from '../api/config'

export default {
  // Obtem as Tribos
  obterPessoa: () => {
    return http.get('Pessoa')
  },
  obterPessoaPorId: (id) => {
    return http.get('Pessoa/' + id)
  },
  obterPessoaPorIdPessoa: (id) => {
    return http.get('Pessoa/tribo/' + id)
  },
  // Altera as info da Pessoa
  alterarPessoa: () => {
    return http.put('Pessoa')
  },
  // Inseri novas Pessoas
  inserirPessoa: () => {
    return http.post('Pessoa')
  },
  // Altera o status, ativando e desativando as Pessoas
  desativarPessoa: () => {
    return http.patch('Pessoa')
  }
}
