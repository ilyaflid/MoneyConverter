using System.ComponentModel.DataAnnotations;

namespace MoneyConverter.Models
{
    public class ConvertAmountRequest
    {
        [Required]
        public string Amount { get; set; } = string.Empty;
    }
}
