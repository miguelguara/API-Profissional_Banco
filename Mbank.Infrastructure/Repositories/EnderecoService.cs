using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Enderecos;
using Mbank.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Infrastructure.Repositories
{
    public class EnderecoService : IenderecoRepository
    {

        private readonly AppDbContext _appDbContext;
        public EnderecoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Endereco?> AlterarEnd(Guid IdEndereco, AlterarEndDTO endereco)
        {
            var end = await _appDbContext.Enderecos.FirstOrDefaultAsync(e => e.Id == IdEndereco);

            if (end == null) return null;

            end.Logradouro = endereco.Logradouro;
            end.Cep = endereco.Cep;
            end.Bairro = endereco.Bairro;
            end.Cidade = endereco.Cidade;
            _appDbContext.Update(end);
            await _appDbContext.SaveChangesAsync();
            return end;
        }

        public async Task<Guid> CadastrarEndereco(CadastroEndDTO endereco)
        {
            var ed = new Endereco(endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.Uf, endereco.ClienteId);
            await _appDbContext.Enderecos.AddAsync(ed);
            _appDbContext.SaveChanges();
            return ed.Id;
        }

        public async Task<List<Endereco>?> ExcluirEndereco(Guid IdEndereco)
        {
            var endereco = await _appDbContext.Enderecos.FirstOrDefaultAsync(e => e.Id == IdEndereco);
            if (endereco == null) return null;

            _appDbContext.Enderecos.Remove(endereco);
             await _appDbContext.SaveChangesAsync();

            return _appDbContext.Enderecos.ToList();

        }

        public async Task<bool> ExcluirTodosEnderecosPorCliente(Guid IdCliente)
        {
            var enderecos = await _appDbContext.Enderecos.Where(e =>e.ClienteId == IdCliente).ToListAsync();

            if(enderecos == null) return false;

            _appDbContext.Enderecos.RemoveRange(enderecos);
            _appDbContext.SaveChanges();

            return true;
        }

        public async Task<List<Endereco>> ListarEnderecos()
        {
            return await _appDbContext.Enderecos.ToListAsync();
        }

        public async Task<List<Endereco>?> ListarEnderecosPorCliente(Guid idCLiente)
        {
            return await _appDbContext.Enderecos.Where(e => e.ClienteId == idCLiente).ToListAsync();
        }
    }
}
