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

        public async Task<Guid> CadastrarEndereco(CadastroEndDTO endereco)
        {
            var ed = new Endereco(endereco.Cep, endereco.Logradouro, endereco.Bairro, endereco.Cidade, endereco.Uf, endereco.ClienteId);
            await _appDbContext.Enderecos.AddAsync(ed);
            _appDbContext.SaveChanges();
            return ed.Id;
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
