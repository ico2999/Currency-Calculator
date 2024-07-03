using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Microsoft.VisualBasic;

namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal CalculateFromEurosToPounds(decimal euro, DateTime exchangeRateDate)

        {
            decimal result = CurrencyFromAndTo(euro, CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Eur, exchangeRateDate);
            return result;
        }

        public decimal CalculateFromUsDollarsToPounds(decimal dollar, DateTime exchangeRateDate)
        {
            decimal result = CurrencyFromAndTo(dollar, CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Usd, exchangeRateDate);
            return result;
        }

        public decimal CalculateFromPoundsToEuros(decimal pound, DateTime exchangeRateDate)
        {
            decimal result = CurrencyFromAndTo(pound, CurrencyTypeEnum.Eur, CurrencyTypeEnum.Gbp, exchangeRateDate);
            return result;
        }

        public decimal CalculateFromPoundsToUsDollars(decimal pound, DateTime exchangeRateDate)
        {
            decimal result = CurrencyFromAndTo(pound, CurrencyTypeEnum.Usd, CurrencyTypeEnum.Gbp, exchangeRateDate);
            return result;
        }

        public decimal CalculateFromUsDollarsToEuros(decimal dollar, DateTime exchangeRateDate)
        {
            decimal result = CurrencyFromAndTo(dollar, CurrencyTypeEnum.Eur, CurrencyTypeEnum.Usd, exchangeRateDate);
            return result;
        }

        public decimal CalculateFromEurosToUsDollars(decimal euro, DateTime exchangeRateDate)
        {
            decimal result = CurrencyFromAndTo(euro, CurrencyTypeEnum.Usd, CurrencyTypeEnum.Eur, exchangeRateDate);
            return result;
        }

        private decimal Convert(decimal currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

        private decimal CurrencyFromAndTo(decimal amountFrom, CurrencyTypeEnum currencyTo, CurrencyTypeEnum currencyFrom, DateTime exchangeRateDate)
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