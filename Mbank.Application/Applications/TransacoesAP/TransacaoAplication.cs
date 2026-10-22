using Mbank.Core.Entitys;
using Mbank.Core.Interfaces.Aplications.TransacoesAP;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Core.Models.Transacoes;

namespace Mbank.Application.Applications.TransacoesAP
{
    public class TransacaoAplication : ItransacaoApp
    {

        private readonly ItransacaoRepository _transacaoRepository;
        private readonly IcofrinhoRepository _cofrinhoRepository;
        private readonly IcarteiraRepository _carteiraRepository;
        private readonly IclienteRepository _clienteRepository;

        public TransacaoAplication(ItransacaoRepository itransacaoRepository, IcarteiraRepository carteiraRepository)
        {
            _transacaoRepository = itransacaoRepository;
            _carteiraRepository = carteiraRepository;
        }
         public async Task<Guid?> RealizarTransacao(TransacaoDepositoDTO trasacao)
        {
            var t = new Transacao(trasacao.Tipo,trasacao.Valor,trasacao.Descricao,trasacao.CarteiraId);
            var carteira = await _carteiraRepository.BuscarCarteiraporID(trasacao.CarteiraId);
            //o valor deve ser positivo.
            if (trasacao.Valor <= 0)
            {
                throw new ArgumentException(
                    "O valor da transação deve ser maior que zero.");
            }

            // Verifica se a carteira existe.
            if (carteira is null)
            {
                throw new KeyNotFoundException(
                    "Carteira não encontrada.");
            }

            switch (trasacao.Tipo) 
            {
                //implementação da regras de negovio
                case Core.Enums.EtipoTransacao.Deposito:   
                    carteira.Saldo += t.Valor;
                    t.SaldoResultante = carteira.Saldo;
                    break;

                case Core.Enums.EtipoTransacao.Saque:
                    if(carteira.Saldo < trasacao.Valor) 
                    {
                     return null;
                    }
                    carteira.Saldo -= t.Valor;
                    t.SaldoResultante = carteira.Saldo;
                    break;

            }
            await _carteiraRepository.AlterarCarteira(carteira);
            await _transacaoRepository.CadastrarTransacao(t);
            return t.Id;
        }
    }
}
