using Mbank.Core.Interfaces.Aplications.Clientes;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Clientes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mbank.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : MainController
    {
        private readonly ICadastroClienteApp _cadastroClienteApp;
        private readonly IAlterarClienteApp _alterarClienteApp;
        private readonly IclienteRepository _crudcliente;

        public ClienteController(ICadastroClienteApp cadastroClienteApp, IclienteRepository icliente, IAlterarClienteApp alterarClienteApp)
        {
            _cadastroClienteApp = cadastroClienteApp;
            _crudcliente = icliente;
            _alterarClienteApp = alterarClienteApp;
        }

        [HttpPost("cadastrarcliente")]
        public async Task<IActionResult> CadastrarCliente(ClienteDTO clienteDTO)
        {
            var Cadastro = await _cadastroClienteApp.CadastrarAsync(clienteDTO);

            if (Cadastro != null) return Ok(Cadastro);

            return BadRequest();
        }

        [HttpGet("listarclientes")]
        public async Task<IActionResult> ListarClientesAtivos()
        {
            var clientes = await _crudcliente.ListarClientes();
            return Ok(clientes);
        }

        [HttpGet("buscarclientepnome/{nomecompleto}")]
        public async Task<IActionResult> BuscarClientePorNome(string nomecompleto)
        {
            var cliente = _crudcliente.BuscarClientePorNome(nomecompleto);
            if (cliente == null) return NotFound();

            return Ok(cliente);
        }

        [HttpPut("altcliente/{id}")]
        public async Task<IActionResult> AlterarCliente(Guid id, AlterarClienteDTO altCliente)
        {
            var cliente = await _alterarClienteApp.AlterarCliente(id, altCliente);
            if (cliente == null) return BadRequest("Não foi possivel realizar a alteração de cliente");
            return Ok(cliente);
        }

        [HttpDelete("deletarCliente/{id}")]
        public async Task<IActionResult> ExcluirCliente(Guid id)
        {
            var cliente = await _crudcliente.ExcluirCliente(id);
            if (cliente == null) return BadRequest();
            return Ok(cliente);
        }
    }
}
