using FluentAssertions;

namespace CurrencyCalculator.Unit
{
    public class CalculatorShould
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Converts100EurosTo85Pounds()
        {
            decimal result = _calculator.CalculateFromEurosToPounds();
            result.Should().Be(85);
        }

        [Fact]
        public void Converts100UsDollarsTo82Pounds()
        {
            decimal result = _calculator.CalculateFromUsDollarsToPounds();
            result.Should().Be(82);
        }

        [Fact]
        public void Converts100PoundsTo117Euros()
        {
            decimal result = _calculator.CalculateFromPoundsToEuros();
            result.Should().Be(117);
        }

        [Fact]
        public void Converts100PoundsTo122UsDollars()
        {
            decimal result = _calculator.CalculateFromPoundsToUsDollars();
            result.Should().Be(122);
        }

        


    }
}