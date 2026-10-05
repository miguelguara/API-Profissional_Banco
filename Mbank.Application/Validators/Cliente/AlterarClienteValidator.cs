using FluentValidation;
using Mbank.Core.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Application.Validators.Cliente
{
    public class AlterarClienteValidator : AbstractValidator<AlterarClienteDTO>
    {
        public AlterarClienteValidator()
        {
            RuleFor(c => c.NomeCompleto).NotEmpty().WithMessage("Para realizar a alteração por gentileza digite um nome.");
            RuleFor(c => c.Telefone).NotEmpty().WithMessage("Para realizar a alteração voce deve colocar um telefone.");
            RuleFor(c => c.Email).NotEmpty().WithMessage("Para realizar a alteração voce deve preencher o E-mail");
        }
    }
}
