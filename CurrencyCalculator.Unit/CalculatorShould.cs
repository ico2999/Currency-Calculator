using FluentAssertions;

namespace CurrencyCalculator.Unit
{
    public class CalculatorShould
    {
        [Fact]
        public void Converts100EurosTo85Pounds()
        {
            Calculator calculator = new Calculator();
            decimal result = calculator.CalculateFromEurosToPounds();
            result.Should().Be(85);
        }

        [Fact]
        public void Converts100UsDollarsTo82Pounds()
        {
            Calculator calculator = new Calculator();
            decimal result = calculator.CalculateFromUsDollarsToPounds();
            result.Should().Be(82);
        }
    }
}