using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Enderecos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mbank.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : MainController
    {
        private readonly IenderecoRepository _enderecoRepository;

        public EnderecoController(IenderecoRepository ienderecoRepository)
        {
            _enderecoRepository = ienderecoRepository;
        }


        [HttpPost("CadastrarEndereco")]
        public async Task<IActionResult> CadastrarEndereco(CadastroEndDTO endereco)
        {
            var end = await _enderecoRepository.CadastrarEndereco(endereco);
            if (end == null) return BadRequest();

            return Ok(end);
        }

        [HttpGet("ListarEnderecos")]
        public async Task<IActionResult> ListarEndereco()
        {
            var end = await _enderecoRepository.ListarEnderecos();
            if (end == null) return NotFound();
            return Ok(end);
        }

        [HttpGet("ListarEnderecosPorCliente/{id}")]
        public async Task<IActionResult> ListarEndereco(Guid id)
        {
            var end = await _enderecoRepository.ListarEnderecosPorCliente(id);
            if (end == null) return NotFound();
            return Ok(end);
        }
    }
}
