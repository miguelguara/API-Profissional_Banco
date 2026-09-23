using FluentValidation;
using Mbank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Application.Validators
{
    public class CadastrarClienteValidation: AbstractValidator<ClienteDTO>
    {
        public CadastrarClienteValidation()
        {
            //Aplicação de regras de validação
            RuleFor(c => c.NomeCompleto).NotNull().WithMessage("Por gentileza escreva o nome completo do cliente");

            RuleFor(c => c.Email).NotNull().WithMessage("Digite o email por favor!").EmailAddress().WithMessage("Digite um email Valido mano");

            RuleFor(c => c.Cpf).NotNull().WithMessage("O CPF não pode ser vazio!");

            RuleFor(c => c.Telefone).NotNull().WithMessage("Por gentileza digite seu telefone!");

            RuleFor(c => c.Senha).NotNull().WithMessage("Deve ser criada uma senha para que seu cadastro seja efetuaco com sucesso!");

        }
    }
}
