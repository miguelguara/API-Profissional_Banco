using System;
using System.Collections.Generic;
using System.Text;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Entitys;
using Mbank.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

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
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente.Id;
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return clientes;
        }

        public async Task<Cliente?> BuscarClientePorNome(string nomeCompleto) 
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.NomeCompleto == nomeCompleto);

           return cliente; 
        }
    }
}
