using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Microsoft.VisualBasic;

namespace CurrencyCalculator
{
    public class Calculator
    {


        private decimal Convert(decimal currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

        public decimal ConvertCurrency(decimal amountFrom, CurrencyTypeEnum currencyFrom, CurrencyTypeEnum currencyTo, DateTime exchangeRateDate)
        {
            decimal exchangeRate = 0;
            if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Gbp && currencyTo == CurrencyTypeEnum.Eur)
            {
                exchangeRate = 1.17m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Gbp && currencyTo == CurrencyTypeEnum.Eur)
            {
                exchangeRate = 1.09m;
            }
            else if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Gbp && currencyTo == CurrencyTypeEnum.Usd)
            {
                exchangeRate = 1.22m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Gbp && currencyTo == CurrencyTypeEnum.Usd)
            {
                exchangeRate = 1.18m;
            }
            else if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Eur && currencyTo == CurrencyTypeEnum.Gbp)
            {
                exchangeRate = 0.85m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Eur && currencyTo == CurrencyTypeEnum.Gbp)
            {
                exchangeRate = 0.8m;
            }
            else if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Eur && currencyTo == CurrencyTypeEnum.Usd)
            {
                exchangeRate = 1.07m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Eur && currencyTo == CurrencyTypeEnum.Usd)
            {
                exchangeRate = 1.03m;
            }
            else if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Usd && currencyTo == CurrencyTypeEnum.Gbp)
            {
                exchangeRate = 0.82m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Usd && currencyTo == CurrencyTypeEnum.Gbp)
            {
                exchangeRate = 0.87m;
            }
            else if (exchangeRateDate == new DateTime(2010, 1, 1) && currencyFrom == CurrencyTypeEnum.Usd && currencyTo == CurrencyTypeEnum.Eur)
            {
                exchangeRate = 0.98m;
            }
            else if (exchangeRateDate == new DateTime(2020, 1, 1) && currencyFrom == CurrencyTypeEnum.Usd && currencyTo == CurrencyTypeEnum.Eur)
            {
                exchangeRate = 0.93m;
            }

            decimal result = Convert(amountFrom, exchangeRate);
            return result;
        }
    }
}