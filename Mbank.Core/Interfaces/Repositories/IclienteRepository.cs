using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Repositories
{
    public interface IclienteRepository
    {
        Task<Guid> AdicionarCliente(Cliente cliente);
        Task<List<Cliente>> ListarClientes();

        Task<Cliente> BuscarClientePorNome(string Nome);
    }
}
