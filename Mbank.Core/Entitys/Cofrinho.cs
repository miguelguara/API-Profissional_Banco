using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys
{
    public partial class Cofrinho
    {
        public Guid Id { get; set; }

        public string Nome { get; set; } = null!;

        public decimal Saldo { get; set; }

        public decimal? Meta { get; set; }

        public Guid CarteiraId { get; set; }
    }
}
