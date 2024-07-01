using FluentAssertions;

namespace CurrencyCalculator.Unit
{
    public class CalculatorShould
    {
        [Fact]
        public void Converts100EurosToPounds()
        {
            Calculator calculator = new Calculator();
            decimal result = calculator.Calculate();
            result.Should().Be(85);
        }
    }
}