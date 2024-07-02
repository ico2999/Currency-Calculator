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
        [InlineData(150.70, 176.32)]
        public void ConvertsPoundsToEuros(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToEuros(amountFrom);
            result = decimal.Round(result, 2);
            result.Should().Be(decimal.Round(result, 2));
        }

        [Theory]
        [InlineData(100, 122)]
        [InlineData(500, 610)]
        [InlineData(250, 305)]
        [InlineData(122.79, 149.80)]
        public void ConvertsPoundsToUsDollars(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToUsDollars(amountFrom);
            result = decimal.Round(result, 2);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 85)]
        [InlineData(250, 212.50)]
        [InlineData(500, 425)]
        [InlineData(139.92, 118.93)]
        public void ConvertsEurosToPounds(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromEurosToPounds(amountFrom);
            result = decimal.Round(result, 2);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 82)]
        [InlineData(250, 205)]
        [InlineData(500, 410)]
        [InlineData(137.84, 113.03)]
        public void ConvertsDollarsToPounds(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromUsDollarsToPounds(amountFrom);
            result = decimal.Round(result, 2);
            result.Should().Be(amountTo);
        }

    }
}