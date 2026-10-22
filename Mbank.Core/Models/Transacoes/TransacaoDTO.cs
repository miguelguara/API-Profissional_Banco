using Mbank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Models.Transacoes
{
    public class TransacaoDTO
    {
        public short Tipo { get; set; }

        public decimal Valor { get; set; }

        public string? Descricao { get; set; }
    }
}
