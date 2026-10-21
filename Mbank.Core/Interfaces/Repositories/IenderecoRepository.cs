using Mbank.Core.Entitys;
using Mbank.Core.Models.Enderecos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Repositories
{
    public interface IenderecoRepository
    {
        Task<Guid> CadastrarEndereco(CadastroEndDTO endereco);
        Task<List<Endereco>> ListarEnderecos();
        Task<List<Endereco>> ListarEnderecosPorCliente(Guid idCLiente);
        Task<Endereco> AlterarEnd(Guid IdEndereco, AlterarEndDTO endereco);
        Task<List<Endereco>> ExcluirEndereco(Guid IdEndereco);
        Task<Guid> ExcluirTodosEnderecosPorCliente(Guid IdCliente);
    }
}
