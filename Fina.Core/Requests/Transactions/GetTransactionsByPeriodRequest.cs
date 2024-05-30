using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionsByPeriodRequest : PagedRequest
    {
        [Required(ErrorMessage = "A data de início é obrigatória")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "A data de fim é obrigatória")]
        public DateTime? EndDate { get; set; }
    }
}