using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Data.Context;
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
        public async Task<Guid> CadastrarCarteira(Carteira carteira)
        {
            _context.Carteiras.Add(carteira);
            _context.SaveChanges();
            return carteira.Id;
        }
    }
}
