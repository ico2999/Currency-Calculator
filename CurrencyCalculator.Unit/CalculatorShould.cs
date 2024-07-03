using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using FluentAssertions;

namespace CurrencyCalculator.Unit
{
    public class CalculatorShould
    {
        private readonly Calculator _calculator = new Calculator();
        // Test for pounds to euros
        [Theory]
        [InlineData(100, 117)]
        [InlineData(200, 234)]
        [InlineData(400, 468)]
        [InlineData(150.70, 176.32)]
        public void ConvertsPoundsToEuros(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToEuros(amountFrom, new DateTime(2010, 1, 1 ));
            result = decimal.Round(result, 2);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(100, 122)]
        [InlineData(500, 610)]
        [InlineData(250, 305)]
        [InlineData(122.79, 149.80)]
        public void ConvertsPoundsToUsDollars(decimal amountFrom, decimal amountTo)
        {
            decimal result = _calculator.CalculateFromPoundsToUsDollars(amountFrom, new DateTime(2010, 1, 1));
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
            decimal result = _calculator.CalculateFromEurosToPounds(amountFrom, new DateTime(2010, 1, 1));
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
            decimal result = _calculator.CalculateFromUsDollarsToPounds(amountFrom, new DateTime(2010, 1, 1));
            result = decimal.Round(result, 2);
            result.Should().Be(amountTo);
        }

        //CURRENCY CONVERSION DATE BASED TESTING

        [Theory]
        [InlineData(2010, 1, 1, 117)]
        [InlineData(2020, 1, 1, 109)]
        public void ConvertPoundsToEurosBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromPoundsToEuros(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(2010, 1, 1, 122)]
        [InlineData(2020, 1, 1, 118)]
        public void ConvertPoundsToDollarsBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromPoundsToUsDollars(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(2010, 1, 1, 82)]
        [InlineData(2020, 1, 1, 87)]
        public void ConvertDollarsToPoundsBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromUsDollarsToPounds(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(2010, 1, 1, 98)]
        [InlineData(2020, 1, 1, 93)]
        public void ConvertDollarsToEurosBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromUsDollarsToEuros(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(2010, 1, 1, 85)]
        [InlineData(2020, 1, 1, 80)]
        public void ConvertEurosToPoundsBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromEurosToPounds(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

        [Theory]
        [InlineData(2010, 1, 1, 107)]
        [InlineData(2020, 1, 1, 103)]
        public void ConvertEurosToDollarsBasedOnDate(int year, int month, int day, decimal amountTo)
        {
            decimal amountFrom = 100;
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _calculator.CalculateFromEurosToUsDollars(amountFrom, olderDate);
            result.Should().Be(amountTo);
        }

    }
}