using MoneyConverter.Service;

namespace MoneyConverter.Tests
{
    public class MoneyConverterTests
    {
        [Fact]
        public void MoneyConversion_FractionValues_Tests()
        {
            Assert.Equal("Zero dollars and one cent", ConverterService.ConvertToString(0.01));
            Assert.Equal("Zero dollars and two cents", ConverterService.ConvertToString(0.02));
            Assert.Equal("Zero dollars and three cents", ConverterService.ConvertToString(0.03));
            Assert.Equal("Zero dollars and four cents", ConverterService.ConvertToString(0.04));
            Assert.Equal("Zero dollars and five cents", ConverterService.ConvertToString(0.05));
            Assert.Equal("Zero dollars and six cents", ConverterService.ConvertToString(0.06));
            Assert.Equal("Zero dollars and seven cents", ConverterService.ConvertToString(0.07));
            Assert.Equal("Zero dollars and eight cents", ConverterService.ConvertToString(0.08));
            Assert.Equal("Zero dollars and nine cents", ConverterService.ConvertToString(0.09));
            Assert.Equal("Zero dollars and ten cents", ConverterService.ConvertToString(0.10));
            Assert.Equal("Zero dollars and eleven cents", ConverterService.ConvertToString(0.11));
            Assert.Equal("Zero dollars and twelve cents", ConverterService.ConvertToString(0.12));
            Assert.Equal("Zero dollars and thirteen cents", ConverterService.ConvertToString(0.13));
            Assert.Equal("Zero dollars and fourteen cents", ConverterService.ConvertToString(0.14));
            Assert.Equal("Zero dollars and fifteen cents", ConverterService.ConvertToString(0.15));
            Assert.Equal("Zero dollars and sixteen cents", ConverterService.ConvertToString(0.16));
            Assert.Equal("Zero dollars and seventeen cents", ConverterService.ConvertToString(0.17));
            Assert.Equal("Zero dollars and eighteen cents", ConverterService.ConvertToString(0.18));
            Assert.Equal("Zero dollars and nineteen cents", ConverterService.ConvertToString(0.19));
            Assert.Equal("Zero dollars and twenty cents", ConverterService.ConvertToString(0.20));
            Assert.Equal("Zero dollars and twenty-one cents", ConverterService.ConvertToString(0.21));
            Assert.Equal("Zero dollars and thirty-one cents", ConverterService.ConvertToString(0.31));
            Assert.Equal("Zero dollars and fourty-one cents", ConverterService.ConvertToString(0.41));
            Assert.Equal("Zero dollars and fifty-one cents", ConverterService.ConvertToString(0.51));
            Assert.Equal("Zero dollars and sixty-one cents", ConverterService.ConvertToString(0.61));
            Assert.Equal("Zero dollars and seventy-one cents", ConverterService.ConvertToString(0.71));
            Assert.Equal("Zero dollars and eighty-one cents", ConverterService.ConvertToString(0.81));
            Assert.Equal("Zero dollars and ninety-one cents", ConverterService.ConvertToString(0.91));

            Assert.Equal("Zero dollars", ConverterService.ConvertToString(0.001));
            Assert.Equal("Zero dollars and ninety-nine cents", ConverterService.ConvertToString(0.994));
            Assert.Equal("One dollar", ConverterService.ConvertToString(0.997));
        }

        [Fact]
        public void MoneyConversion_IntegerValues_Tests()
        {
            Assert.Equal("Zero dollars", ConverterService.ConvertToString(0));
            Assert.Equal("One dollar", ConverterService.ConvertToString(1));
            Assert.Equal("Two dollars", ConverterService.ConvertToString(2));
            Assert.Equal("Three dollars", ConverterService.ConvertToString(3));
            Assert.Equal("Four dollars", ConverterService.ConvertToString(4));
            Assert.Equal("Five dollars", ConverterService.ConvertToString(5));
            Assert.Equal("Six dollars", ConverterService.ConvertToString(6));
            Assert.Equal("Seven dollars", ConverterService.ConvertToString(7));
            Assert.Equal("Eight dollars", ConverterService.ConvertToString(8));
            Assert.Equal("Nine dollars", ConverterService.ConvertToString(9));
            Assert.Equal("Ten dollars", ConverterService.ConvertToString(10));
            Assert.Equal("Eleven dollars", ConverterService.ConvertToString(11));
            Assert.Equal("Twelve dollars", ConverterService.ConvertToString(12));
            Assert.Equal("Thirteen dollars", ConverterService.ConvertToString(13));
            Assert.Equal("Fourteen dollars", ConverterService.ConvertToString(14));
            Assert.Equal("Fifteen dollars", ConverterService.ConvertToString(15));
            Assert.Equal("Sixteen dollars", ConverterService.ConvertToString(16));
            Assert.Equal("Seventeen dollars", ConverterService.ConvertToString(17));
            Assert.Equal("Eighteen dollars", ConverterService.ConvertToString(18));
            Assert.Equal("Nineteen dollars", ConverterService.ConvertToString(19));
            Assert.Equal("Twenty dollars", ConverterService.ConvertToString(20));
            Assert.Equal("Twenty-two dollars", ConverterService.ConvertToString(22));
            Assert.Equal("Thirty-two dollars", ConverterService.ConvertToString(32));
            Assert.Equal("Fourty-two dollars", ConverterService.ConvertToString(42));
            Assert.Equal("Fifty-two dollars", ConverterService.ConvertToString(52));
            Assert.Equal("Sixty-two dollars", ConverterService.ConvertToString(62));
            Assert.Equal("Seventy-two dollars", ConverterService.ConvertToString(72));
            Assert.Equal("Eighty-two dollars", ConverterService.ConvertToString(82));
            Assert.Equal("Ninety-two dollars", ConverterService.ConvertToString(92));

            Assert.Equal("One hundred dollars", ConverterService.ConvertToString(100));
            Assert.Equal("One hundred one dollars", ConverterService.ConvertToString(101));
            Assert.Equal("One hundred ten dollars", ConverterService.ConvertToString(110));
            Assert.Equal("One hundred twenty-one dollars", ConverterService.ConvertToString(121));
            Assert.Equal("One hundred thirty dollars", ConverterService.ConvertToString(130));

            Assert.Equal("One thousand dollars", ConverterService.ConvertToString(1000));
            Assert.Equal("One thousand one dollars", ConverterService.ConvertToString(1001));
            Assert.Equal("One thousand one hundred dollars", ConverterService.ConvertToString(1100));
            Assert.Equal("Ten thousand dollars", ConverterService.ConvertToString(10000));
            Assert.Equal("Twenty-one thousand dollars", ConverterService.ConvertToString(21000));
            Assert.Equal("One hundred thousand dollars", ConverterService.ConvertToString(100000));
            Assert.Equal("One hundred thousand one dollars", ConverterService.ConvertToString(100001));
            Assert.Equal("One hundred thousand one hundred one dollars", ConverterService.ConvertToString(100101));
            Assert.Equal("One hundred one thousand dollars", ConverterService.ConvertToString(101000));

            Assert.Equal("One million dollars", ConverterService.ConvertToString(1000000));
            Assert.Equal("One million one thousand dollars", ConverterService.ConvertToString(1001000));
            Assert.Equal("One million ten thousand dollars", ConverterService.ConvertToString(1010000));
            Assert.Equal("One million one hundred thousand dollars", ConverterService.ConvertToString(1100000));
            Assert.Equal("Ten million dollars", ConverterService.ConvertToString(10000000));
            Assert.Equal("Twenty-one million dollars", ConverterService.ConvertToString(21000000));
            Assert.Equal("One hundred million dollars", ConverterService.ConvertToString(100000000));
        }

        [Fact]
        public void MoneyConversion_Exceptions_Tests()
        {
            Assert.Throws<Exception>(() => ConverterService.ConvertToString(-10));
            Assert.Throws<Exception>(() => ConverterService.ConvertToString(1000000000));
        }

        [Fact]
        public void MoneyConversionFromString_Exceptions_Tests()
        {
            Assert.Throws<Exception>(() => ConverterService.ConvertToString(string.Empty));
            Assert.Throws<Exception>(() => ConverterService.ConvertToString("123a"));
            Assert.Throws<Exception>(() => ConverterService.ConvertToString("123.23"));
        }

        [Fact]
        public void MoneyConversionFromString_Valid_Tests()
        {
            Assert.Equal("Zero dollars and twenty-three cents", ConverterService.ConvertToString("0,23"));
            Assert.Equal("Twenty-three dollars", ConverterService.ConvertToString(" 23 "));
            Assert.Equal("Four hundred fifty-six thousand dollars and ninety cents", ConverterService.ConvertToString("456 000, 90"));
        }
    }
}