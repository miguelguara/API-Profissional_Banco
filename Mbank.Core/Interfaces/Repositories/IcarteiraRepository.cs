using Mbank.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Repositories
{
    public interface IcarteiraRepository
    {
        public Task<Guid> CadastrarCarteira(Carteira carteira);
        public Task<Carteira> BuscarCarteiraporID(Guid Id);
        public Task<List<Carteira>> MostrarCarteiras();

        public Task<bool> AlterarCarteira(Carteira carteira);
    }
}
