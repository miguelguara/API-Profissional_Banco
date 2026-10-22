using Mbank.Core.Entitys;
using Mbank.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys;

public class Transacao
{
    public Transacao(EtipoTransacao tipo,decimal valor, string? descricao, Guid carteiraId,Guid? cofrinhoId = null)
    {
        Id = Guid.NewGuid();
        Data = DateTime.UtcNow;
        Tipo = tipo;
        Valor = valor;
        Descricao = descricao;
        CarteiraId = carteiraId;
        CofrinhoId = cofrinhoId;
    }

    public Guid Id { get; set; }

    public EtipoTransacao Tipo { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor { get; set; }

    public decimal SaldoResultante { get; set; }

    public string? Descricao { get; set; }

    public Guid CarteiraId { get; set; }

    public Guid? CofrinhoId { get; set; }
}
