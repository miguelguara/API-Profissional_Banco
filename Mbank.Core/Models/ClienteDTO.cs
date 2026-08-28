using Mbank.Core.Enums;

namespace Mbank.Core.Models
{
    public class ClienteDTO
    {
        public ClienteDTO(string nomeCompleto, string email, string cpf, DateOnly datanacimento,string telefone, string senha)
        {
            NomeCompleto = nomeCompleto;
            Situacao = ESituacaoCliente.Ativo;
            Email = email;
            Cpf = cpf;
            DataNascimento = datanacimento;
            Telefone = telefone;
            Senha = senha;
        }

        public string NomeCompleto { get; set; }

        public ESituacaoCliente Situacao { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateOnly DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Senha { get; set; }
    }
}
