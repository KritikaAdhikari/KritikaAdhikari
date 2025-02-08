using System.ComponentModel.DataAnnotations;

namespace BudgetWise.Models
{
    public class Cost
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
