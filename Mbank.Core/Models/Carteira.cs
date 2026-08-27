using Mbank.Core.Models;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Models;

public partial class Carteira
{
    public Guid Id { get; set; }

    public decimal Saldo { get; set; }

    public string Conta { get; set; } = null!;

    public string Agencia { get; set; } = null!;

    public Guid ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<Cofrinho> Cofrinhos { get; set; } = new List<Cofrinho>();

    public virtual ICollection<Transacao> Transacaos { get; set; } = new List<Transacao>();
}
