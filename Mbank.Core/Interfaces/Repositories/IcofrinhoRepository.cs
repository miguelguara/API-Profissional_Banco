using Mbank.Core.Entitys;
using Mbank.Core.Models.Cofrinhos;


namespace Mbank.Core.Interfaces.Repositories
{
    public interface IcofrinhoRepository
    {
        Task<Guid> CriarCofrinho(CadastrarCofrinhoDTO cofre);
        Task<Guid> AlterarCofre(Guid id, Cofrinho cofre);

        Task<Cofrinho?> BuscarCofreporID(Guid Id);
        Task<List<Cofrinho>?> BuscarCofresdoCliente(Guid id);

        Task<bool> ExcluirCofre(Guid Id);
    }
}
