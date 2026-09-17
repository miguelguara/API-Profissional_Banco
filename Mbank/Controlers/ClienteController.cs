using Mbank.Core.Interfaces.Aplications;
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

        public ClienteController(ICadastroClienteApp cadastroClienteApp)
        {
            _cadastroClienteApp = cadastroClienteApp;
        }

        [HttpPost("cadastrarcliente")]
        public async Task<IActionResult> CadastrarCliente(ClienteDTO clienteDTO) 
        {
           var Cadastro = await _cadastroClienteApp.CadastrarAsync(clienteDTO);

            if(Cadastro != null) return Ok(Cadastro);

            return BadRequest();
        }
    }
}
