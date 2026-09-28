using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Aplications;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Application.Applications
{
    public class AlterarClienteAplication : IAlterarClienteApp
    {
        private readonly IclienteRepository _clienteRepository;
        public AlterarClienteAplication(IclienteRepository iclienteRepository)
        {
            _clienteRepository = iclienteRepository;
        }
        public async Task<Cliente> AlterarCliente(Guid id, AlterarClienteDTO altCliente)
        {
            var cliente = await _clienteRepository.BuscarClienteID(id);

            cliente.NomeCompleto = altCliente.NomeCompleto;
            cliente.Email = altCliente.Email;
            cliente.Telefone = altCliente.Telefone;

            return await _clienteRepository.AlterarCliente(cliente);
        }
    }
}
