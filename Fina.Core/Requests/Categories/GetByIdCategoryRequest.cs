using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class GetByIdCategoryRequest : Request
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public long Id { get; set; }
    }
}