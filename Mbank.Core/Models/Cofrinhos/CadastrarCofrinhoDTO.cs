using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Models.Cofrinhos
{
    public class CadastrarCofrinhoDTO
    {
        public string Nome { get; set; } = null!;

        public decimal Saldo { get; set; }

        public decimal? Meta { get; set; }

        public Guid CarteiraId { get; set; }
    }
}
