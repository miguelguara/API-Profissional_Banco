using Mbank.Core.Interfaces.Aplications;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mbank.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : MainController
    {
        private readonly ICadastroClienteApp _cadastroClienteApp;
        private readonly IclienteRepository _crudcliente;

        public ClienteController(ICadastroClienteApp cadastroClienteApp, IclienteRepository icliente)
        {
            _cadastroClienteApp = cadastroClienteApp;
            _crudcliente = icliente;
        }

        [HttpPost("cadastrarcliente")]
        public async Task<IActionResult> CadastrarCliente(ClienteDTO clienteDTO) 
        {
           var Cadastro = await _cadastroClienteApp.CadastrarAsync(clienteDTO);

            if(Cadastro != null) return Ok(Cadastro);

            return BadRequest();
        }

        [HttpGet("listarclientes")]
        public async Task<IActionResult> ListarClientesAtivos() 
        {
         var clientes = await _crudcliente.ListarClientes();
         return Ok(clientes);
        }

        [HttpGet("buscarclientepnome/{nomecompleto}")]
        public async Task<IActionResult>BuscarClientePorNome(string nomecompleto) 
        {
        }

    }
}
