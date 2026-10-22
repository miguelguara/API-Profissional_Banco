using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Infrastructure.Repositories
{
    public class CarteiraService : IcarteiraRepository
    {
        private readonly AppDbContext _context;
        public CarteiraService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<bool> AlterarCarteira(Carteira carteira)
        {
            _context.Carteiras.Update(carteira);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Carteira?> BuscarCarteiraporID(Guid Id)
        {
            return await _context.Carteiras.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<Guid> CadastrarCarteira(Carteira carteira)
        {
            _context.Carteiras.Add(carteira);
            _context.SaveChanges();
            return carteira.Id;
        }

        public async Task<List<Carteira>> MostrarCarteiras()
        {
            var carteiras = await _context.Carteiras.ToListAsync();
            return carteiras;
        }
    }
}
