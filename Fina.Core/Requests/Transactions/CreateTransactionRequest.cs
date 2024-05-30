using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions
{
    public class CreateTransactionRequest : Request
    {
        [Required(ErrorMessage = "O Titulo é obrigatório")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Valor é obrigatório")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        [Required(ErrorMessage = "O Valor é obrigatório")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "A Categoria é obrigatória")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "A Data é obrigatória")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}