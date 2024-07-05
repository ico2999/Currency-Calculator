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
                
            decimal result = calculator.ConvertCurrency(value,currencyTypeFrom, currencyTypeTo, exchangeRateDate);
	        return result;
        }
    }
}
