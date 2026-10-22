using Mbank.Core.Models.Transacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Aplications.TransacoesAP
{
    public interface ItransacaoApp
    {
        Task<Guid?> RealizarTransacao(TransacaoDepositoDTO trasacao);
    }
}
