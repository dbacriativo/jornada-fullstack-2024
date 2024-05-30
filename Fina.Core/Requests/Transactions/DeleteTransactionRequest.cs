using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions
{
    public class DeleteTransactionRequest : Request
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public long Id { get; set; }
    }
}