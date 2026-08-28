using System;
using System.Collections.Generic;
using System.Text;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Entitys;
using Mbank.Infrastructure.Data.Context;

namespace Mbank.Infrastructure.Repositories
{
    public class ClienteService : IclienteRepository
    {

        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> AdicionarCliente(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();
            await _context.Clientes.AddAsync(cliente);
            _context.SaveChanges();
            return cliente.Id;
        }
    }
}
