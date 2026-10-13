using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Models.Enderecos
{
    public class CadastroEndDTO
    {
        public string Cep { get; set; } = null!;

        public string Logradouro { get; set; } = null!;

        public string Bairro { get; set; } = null!;

        public string Cidade { get; set; } = null!;

        public string Uf { get; set; } = null!;

        public Guid ClienteId { get; set; }
    }
}
