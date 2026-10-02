using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Aplications.Clientes;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Application.Applications
{
    public class CadastrarCAplication : ICadastroClienteApp
    {
        private readonly IclienteRepository _clienteRepository;

        public CadastrarCAplication(IclienteRepository repo)
        {
            _clienteRepository = repo;
        }
        public async Task<Guid> CadastrarAsync(ClienteDTO cliente)
        {
           return await _clienteRepository.AdicionarCliente(new Cliente(cliente.NomeCompleto, cliente.Email, cliente.Cpf, cliente.DataNascimento, cliente.Telefone, cliente.Senha));
        }
    }
}
