using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Infrastructure.Repositories
{
    public class TransacaoService : ItransacaoRepository
    {
        private readonly AppDbContext _appDbContext;
        public TransacaoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Guid> CadastrarTransacao(Transacao transacao)
        {
            await _appDbContext.Transacaos.AddAsync(transacao);
            await _appDbContext.SaveChangesAsync();
            return transacao.Id;
        }
    }
}
