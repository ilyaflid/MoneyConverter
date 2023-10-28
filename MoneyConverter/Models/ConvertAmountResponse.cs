namespace MoneyConverter.Models
{
    public class ConvertAmountResponse
    {
        public string AmountString { get; private set; } = string.Empty;

        public ConvertAmountResponse(string amount)
        {
            AmountString = amount;
        }
    }
}
