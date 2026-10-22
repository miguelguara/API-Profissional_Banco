using Mbank.Core.Enums;


namespace Mbank.Core.Models.Transacoes
{
    public class TransacaoDepositoDTO
    {
        public EtipoTransacao Tipo { get; set; }

        public decimal Valor { get; set; }

        public string? Descricao { get; set; }
        public Guid CarteiraId { get; set; }
    }
}
