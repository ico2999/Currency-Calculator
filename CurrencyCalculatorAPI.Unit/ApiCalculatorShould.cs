using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using CurrencyCalculator;
using CurrencyCalculator.API;
using FluentAssertions;

namespace CurrencyCalculatorAPI.Unit
{
    public class ApiCalculatorShould
    {

        private readonly CurrencyCalculator.API.CurrencyConverterController _currencyController = new CurrencyCalculator.API.CurrencyConverterController();

        [Theory]
        [InlineData(100, CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Eur, 2010, 1, 1)]
        [InlineData(300, CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Usd, 2020, 1, 1)]
        [InlineData(20, CurrencyTypeEnum.Eur, CurrencyTypeEnum.Gbp, 2010, 1, 1)]
        [InlineData(987, CurrencyTypeEnum.Eur, CurrencyTypeEnum.Usd, 2010, 1, 1)]
        [InlineData(8743, CurrencyTypeEnum.Usd, CurrencyTypeEnum.Eur, 2020, 1, 1)]
        [InlineData(210, CurrencyTypeEnum.Usd, CurrencyTypeEnum.Gbp, 2020, 1, 1)]
        public void ConvertCurrencyTest(decimal value, CurrencyTypeEnum currencyFrom, CurrencyTypeEnum currencyTo, int year, int month, int day)
        {
            DateTime olderDate = new DateTime(year, month, day);
            decimal result = _currencyController.ConvertCurrency(value, currencyFrom, currencyTo, new DateTime(year, month, day));
            result.Should().Be(result);
        }
    }
}