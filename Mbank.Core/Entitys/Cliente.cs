using Mbank.Core.Entitys;
using Mbank.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mbank.Core.Entitys;

public partial class Cliente
{
    public Cliente( string nomeCompleto, string email, string cpf, DateOnly dataNascimento, string telefone, string senha)
    {
        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        Situacao = ESituacaoCliente.Ativo;
        Email = email;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        Senha = senha;
    }

    [Key]
    public Guid Id { get; set; }

    public string NomeCompleto { get; set; }

    public ESituacaoCliente Situacao { get; set; }

    public string Email { get; set; }

    public string Cpf { get; set; } 

    public DateOnly DataNascimento { get; set; }
    public string Telefone { get; set; } 

    public string Senha { get; set; } 

}
