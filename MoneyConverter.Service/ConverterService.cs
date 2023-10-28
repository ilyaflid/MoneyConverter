using System.Globalization;

namespace MoneyConverter.Service
{
    public static class ConverterService
    {
        private static NumberFormatInfo _numberFormat = 
            new NumberFormatInfo() { NumberDecimalSeparator = Constants.DecimalSeparator };

        public static string ConvertToString(string amountToConvert)
        {
            double sumToConvertDouble = 0;
            amountToConvert = amountToConvert.Replace(' '.ToString(), "");

            try
            {
                sumToConvertDouble = Convert.ToDouble(amountToConvert, _numberFormat);
            }
            catch (FormatException e)
            {
                throw new Exception("This is not a valid number");
            }
            catch (Exception e)
            {
                throw new Exception($"Some strange exception: {e.Message}");
            }

            return ConvertToString(sumToConvertDouble);
        }

        public static string ConvertToString(double amountToConvert)
        {
            if (amountToConvert < 0)
                throw new Exception("The amount must be non-negative");

            if (amountToConvert >= 1000000000)
                throw new Exception("This is too large amount");

            amountToConvert = Math.Round(amountToConvert, 2);

            var integerPart = Convert.ToInt32(Math.Floor(amountToConvert));
            var fractionPart = Convert.ToInt32((amountToConvert - integerPart) * 100);

            var convertedString = MoneyAmountAsString(integerPart, Constants.Dollar);
            if (fractionPart > 0)
                convertedString += $" and {MoneyAmountAsString(fractionPart, Constants.Cent)}";

            return char.ToUpper(convertedString.FirstOrDefault()) + convertedString.Substring(1);
        }

        private static string MoneyAmountAsString(int amount, string valueName)
        {
            var numberPart = NumberToString(amount);
            var valuePart = amount == 1 ? valueName : PluralForm(valueName);
            return $"{numberPart} {valuePart}";
        }

        private static string NumberToString(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 10)
                return Number1to9ToString(number);

            if (number < 20)
                return Number10to19ToString(number);

            if (number < 100)
                return Number20to99ToString(number);

            if (number < 1000)
                return Number100to999ToString(number);

            if (number < 1000000)
                return Number1000to999999ToString(number);

            return Number1000000to999999999ToString(number);
        }

        private static string Number1to9ToString(int number)
        {
            return number switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                _ => string.Empty
            };
        }

        private static string Number10to19ToString(int number)
        {
            return number switch
            {
                10 => "ten",
                11 => "eleven",
                12 => "twelve",
                13 => "thirteen",
                14 => "fourteen",
                15 => "fifteen",
                16 => "sixteen",
                17 => "seventeen",
                18 => "eighteen",
                19 => "nineteen",
                _ => string.Empty
            };
        }

        private static string Number20to99ToString(int number)
        {
            var unitsNumber = number % 10;
            var tensNumber = number - unitsNumber;

            var tensNumberString = tensNumber switch
            {
                20 => "twenty",
                30 => "thirty",
                40 => "fourty",
                50 => "fifty",
                60 => "sixty",
                70 => "seventy",
                80 => "eighty",
                90 => "ninety",
                _ => string.Empty
            };
            return tensNumberString + 
                (unitsNumber > 0 ? $"-{Number1to9ToString(unitsNumber)}" : string.Empty);
        }

        private static string Number100to999ToString(int number)
        {
            var unitsNumber = number % 100;
            var numberOfHundreds = (number - unitsNumber) / 100;

            return $"{Number1to9ToString(numberOfHundreds)} hundred" +
                (unitsNumber > 0 ? $" {NumberToString(unitsNumber)}" : string.Empty);
        }

        private static string Number1000to999999ToString(int number)
        {
            var unitsNumber = number % 1000;
            var numberOfThousands = (number - unitsNumber) / 1000;

            return $"{NumberToString(numberOfThousands)} thousand" +
                (unitsNumber > 0 ? $" {NumberToString(unitsNumber)}" : string.Empty);
        }

        private static string Number1000000to999999999ToString(int number)
        {
            var unitsNumber = number % 1000000;
            var numberOfMillions = (number - unitsNumber) / 1000000;

            return $"{NumberToString(numberOfMillions)} million" +
                (unitsNumber > 0 ? $" {NumberToString(unitsNumber)}" : string.Empty);
        }
        private static string PluralForm(string word) => $"{word}s";
    }
}