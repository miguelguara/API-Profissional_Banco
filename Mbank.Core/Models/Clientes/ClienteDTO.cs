using Mbank.Core.Enums;

namespace Mbank.Core.Models.Clientes
{
    public class ClienteDTO
    {
        public string NomeCompleto { get; set; }

        public ESituacaoCliente Situacao { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public DateOnly DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Senha { get; set; }
    }
}
