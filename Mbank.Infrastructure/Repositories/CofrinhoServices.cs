using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Infrastructure.Repositories
{
    public class CofrinhoServices : IcofrinhoRepository
    {
        public Task<Guid> AlterarCofre(Guid id, Cofrinho cofre)
        {
            throw new NotImplementedException();
        }

        public Task<Cofrinho?> BuscarCofreporID(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cofrinho>?> BuscarCofresdoCliente(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> CriarCofrinho(Cofrinho cofre)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirCofre(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
