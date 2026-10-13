using System;
using System.Collections.Generic;

namespace Mbank.Core.Entitys;

public partial class Endereco
{
    public Endereco(string cep, string logradouro, string bairro, string cidade, string uf, Guid clienteId)
    {
        Id = Guid.NewGuid();
        Cep = cep;
        Logradouro = logradouro;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
        ClienteId = clienteId;
    }
    public Guid Id { get; set; }

    public string Cep { get; set; } = null!;

    public string Logradouro { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public Guid ClienteId { get; set; }
}
