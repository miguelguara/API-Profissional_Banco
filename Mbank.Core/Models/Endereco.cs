using System;
using System.Collections.Generic;

namespace Mbank.Core.Models;

public partial class Endereco
{
    public Guid Id { get; set; }

    public string Cep { get; set; } = null!;

    public string Logradouro { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public Guid ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
