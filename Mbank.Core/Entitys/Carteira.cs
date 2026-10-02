using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys;

public class Carteira
{
    public Carteira(decimal saldo, string conta, string agencia,Guid idcliente)
    {
        Id = Guid.NewGuid();
        Saldo = saldo;
        Conta = conta;
        Agencia = agencia;
        ClienteId = idcliente;
    }
    public Guid Id { get; set; }

    public decimal Saldo { get; set; }

    public string Conta { get; set; } = null!;

    public string Agencia { get; set; } = null!;

    public Guid ClienteId { get; set; }

}
