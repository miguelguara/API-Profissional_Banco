using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys;

public partial class Carteira
{
    public Guid Id { get; set; }

    public decimal Saldo { get; set; }

    public string Conta { get; set; } = null!;

    public string Agencia { get; set; } = null!;

    public Guid ClienteId { get; set; }

}
