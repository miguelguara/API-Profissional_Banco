using Mbank.Core.Interfaces.Aplications.TransacoesAP;
using Mbank.Core.Models.Transacoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mbank.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ItransacaoApp _transacaoApp;

        public TransacaoController(ItransacaoApp itransacaoApp)
        {
            _transacaoApp = itransacaoApp;
        }
        [HttpPost("RealizarTransacao")]
        public async Task<IActionResult> FazerTransacao(TransacaoDepositoDTO transacao) 
        {
            var t = await _transacaoApp.RealizarTransacao(transacao);
            if(t == null) return BadRequest();
            return Ok(t);
        }
    }
}
