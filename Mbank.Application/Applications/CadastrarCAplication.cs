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
        private readonly IcarteiraRepository _carteiraRepository;

        public CadastrarCAplication(IclienteRepository repo, IcarteiraRepository carteiraRepository)
        {
            _clienteRepository = repo;
            _carteiraRepository = carteiraRepository;
        }
        public async Task<Guid> CadastrarAsync(ClienteDTO cliente)
        {
           var clienteID = await _clienteRepository.AdicionarCliente(new Cliente(cliente.NomeCompleto, cliente.Email, cliente.Cpf, cliente.DataNascimento, cliente.Telefone, cliente.Senha));

            try 
            {
                var carteira = new Carteira(clienteID);
                var idCarteira = await _carteiraRepository.CadastrarCarteira(carteira);
                return clienteID;
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
