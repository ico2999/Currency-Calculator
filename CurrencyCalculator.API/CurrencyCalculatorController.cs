using System.Security.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyCalculator.API
{

    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        [HttpGet]
        public decimal ConvertCurrency(decimal value, CurrencyTypeEnum currencyTypeFrom, CurrencyTypeEnum currencyTypeTo, DateTime exchangeRateDate)
        {
            Calculator calculator = new Calculator();
            if (currencyTypeFrom == CurrencyTypeEnum.Eur && currencyTypeTo == CurrencyTypeEnum.Gbp)
            {
                decimal result = calculator.CalculateFromEurosToPounds(value, exchangeRateDate);
                return result;
            }
            else if (currencyTypeFrom == CurrencyTypeEnum.Eur && currencyTypeTo == CurrencyTypeEnum.Usd)
            {
                decimal result = calculator.CalculateFromEurosToUsDollars(value, exchangeRateDate);
                return result;
            }
            else if (currencyTypeFrom == CurrencyTypeEnum.Gbp && currencyTypeTo == CurrencyTypeEnum.Eur)
            {
                decimal result = calculator.CalculateFromPoundsToEuros(value, exchangeRateDate);
                return result;
            }
            else if (currencyTypeFrom == CurrencyTypeEnum.Gbp && currencyTypeTo == CurrencyTypeEnum.Usd)
            {
                decimal result = calculator.CalculateFromPoundsToUsDollars(value, exchangeRateDate);
                return result;
            }
            else if (currencyTypeFrom == CurrencyTypeEnum.Usd && currencyTypeTo == CurrencyTypeEnum.Eur)
            {
                decimal result = calculator.CalculateFromUsDollarsToEuros(value, exchangeRateDate);
                return result;
            }
            else if (currencyTypeFrom == CurrencyTypeEnum.Usd && currencyTypeTo == CurrencyTypeEnum.Gbp)
            {
                decimal result = calculator.CalculateFromUsDollarsToPounds(value, exchangeRateDate);
                return result;
            }

            throw new Exception("No currency conversion available.");
        }
    }
}
