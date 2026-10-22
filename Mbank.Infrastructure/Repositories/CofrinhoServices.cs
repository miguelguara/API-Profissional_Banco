using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Cofrinhos;
using Mbank.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Infrastructure.Repositories
{
    public class CofrinhoServices : IcofrinhoRepository
    {
        private readonly AppDbContext _appDbContext;
        public CofrinhoServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Task<Guid> AlterarCofre(Guid id, Cofrinho cofre)
        {
            throw new NotImplementedException();
        }

        public async Task<Cofrinho?> BuscarCofreporID(Guid Id)
        {
            return await _appDbContext.Cofrinhos.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<List<Cofrinho>?> BuscarCofresdoCliente(Guid id)
        {
            var carteira = await _appDbContext.Carteiras.FirstOrDefaultAsync(c => c.ClienteId == id); 
            var cofres = await _appDbContext.Cofrinhos.Where(cr => cr.CarteiraId == carteira.Id).ToListAsync();
            return cofres;
        }

        public async Task<Guid> CriarCofrinho(CadastrarCofrinhoDTO cofre)
        {
            var c = new Cofrinho(
                cofre.Nome,
                cofre.Meta,
                cofre.CarteiraId
                );

            _appDbContext.Cofrinhos.Add(c);
            await _appDbContext.SaveChangesAsync();

            return c.Id;
        }

        public async Task<bool> ExcluirCofre(Guid Id)
        {
            var cofre = _appDbContext.Cofrinhos.FirstOrDefault(c => c.Id == Id);

            if (cofre == null) return false;

            _appDbContext.Cofrinhos.Remove(cofre);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
