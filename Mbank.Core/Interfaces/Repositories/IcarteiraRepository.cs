using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Repositories
{
    public interface IcarteiraRepository
    {
        public Task<Guid> CadastrarCarteira(Carteira carteira);
    }
}
