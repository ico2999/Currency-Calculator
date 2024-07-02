using System.Runtime.InteropServices;
using FluentAssertions;

namespace CurrencyCalculator.Unit
{
    public class CalculatorShould
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(100, 117)]
        [InlineData(200, 234)]
        [InlineData(400, 468)]
        public void ConvertsPoundsToEuros(int amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToEuros(amountFrom);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 122)]
        [InlineData(500, 610)]
        [InlineData(250, 305)]
        public void ConvertsPoundsToUsDollars(int amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToUsDollars(amountFrom);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 85)]
        [InlineData(250, 212.50)]
        [InlineData(500, 425)]
        public void ConvertsEurosToPounds(int amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromEurosToPounds(amountFrom);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 82)]
        [InlineData(250, 205)]
        [InlineData(500, 410)]
        public void ConvertsDollarsToPounds(int amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromUsDollarsToPounds(amountFrom);
            result.Should().Be(amountTo);
        }


    }
}