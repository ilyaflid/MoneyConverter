using System.Text.Json;

namespace MoneyConverter.Models
{
    public class ErrorDetails
    {
        public string Message { get; set; }
        public ErrorDetails(string message)
        {
            Message = message;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
