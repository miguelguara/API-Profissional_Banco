using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys;

public class Carteira
{
    public Carteira(Guid clienteId)
    {
        Id = Guid.NewGuid();
        Saldo = 0;
        Conta = gerarConta();
        Agencia = "0001";
        ClienteId = clienteId;
    }
    public Guid Id { get; set; }

    public decimal Saldo { get; set; }

    public string Conta { get; set; } = null!;

    public string Agencia { get; set; } = null!;

    public Guid ClienteId { get; set; }

    private string gerarConta() 
    {
        var r = new Random();

        int numerodaConta = r.Next(10000000, 99999999);

        int digito = r.Next(0, 10);

        return $"{numerodaConta}-{digito}";
    }


}
