using System.Security.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyCalculator.API
{

    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        [HttpGet]
        public decimal GetEurosToPounds()
        {
            Calculator calculator = new Calculator();
            decimal result = calculator.CalculateFromEurosToPounds(100, new DateTime(2010, 1, 1));
            return result;
        }

        //[HttpGet]
        //public decimal ConvertCurrency(decimal value, CurrencyTypeEnum currencyTypeFrom, CurrencyTypeEnum currencyTypeTo, DateTime exchangeRateDate)
        //{
        //    Calculator calculator = new Calculator();
        //    if (currencyTypeFrom == CurrencyTypeEnum.Eur && currencyTypeTo == CurrencyTypeEnum.Gbp)
        //    {
        //        decimal result = calculator.CalculateFromEurosToPounds(value, exchangeRateDate);
        //        return result;
        //    }

        //    throw new NotImplementedException("I haven't finished");
        //}
    }
}
