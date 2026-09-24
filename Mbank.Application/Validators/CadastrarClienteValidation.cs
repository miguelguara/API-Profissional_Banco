using FluentValidation;
using Mbank.Core.Entitys;
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
            RuleFor(c => c.NomeCompleto).NotEmpty().WithMessage("Por gentileza escreva o nome completo do cliente").NotEmpty().WithMessage("Já disse pra não deixar vazio");

            RuleFor(c => c.Email).NotEmpty().WithMessage("Digite o email por favor!").EmailAddress().WithMessage("Digite um email Valido mano");

            RuleFor(c => c.Cpf).NotEmpty().WithMessage("O CPF não pode ser vazio!");

            RuleFor(c => c.Telefone).NotEmpty().WithMessage("Por gentileza digite seu telefone!");

            RuleFor(c => c.Senha).NotEmpty().WithMessage("Deve ser criada uma senha para que seu cadastro seja efetuaco com sucesso!");

        }
    }
}
