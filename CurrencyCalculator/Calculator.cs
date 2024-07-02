using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal CalculateFromEurosToPounds(decimal euro, DateTime exchangeRateDate)

        {
            decimal exchangeRate = 0;

            if (exchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 0.85m;
            }
            else
            {
                exchangeRate = 0.80m;
            }

            decimal result = Convert(euro, exchangeRate);
            return result;
        }

        public decimal CalculateFromUsDollarsToPounds(decimal dollars, DateTime exchangeRateDate)
        {
            decimal exchangeRate = 0;

            if (exchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 0.82m;
            }
            else
            {
                exchangeRate = 0.87m;
            }

            decimal result = Convert(dollars, exchangeRate);
            return result;
        }

        public decimal CalculateFromPoundsToEuros(decimal pound, DateTime exchangeRateDate)
        {
            decimal exchangeRate = 0;

            if (exchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 1.17m;
            }
            else
            {
                exchangeRate = 1.09m;
            }
                
            decimal result = Convert(pound, exchangeRate);
            return result;
        }

        public decimal CalculateFromPoundsToUsDollars(decimal pound, DateTime exchangeRateDate)
        {
            decimal exchangeRate = 0;
            if (exchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 1.22m;
            }
            else
            {
                exchangeRate = 1.18m;
            }

            decimal result = Convert(pound, exchangeRate);
            return result;
        }

        public decimal CalculateFromUsDollarsToEuros(decimal dollar, DateTime exchangeRateDate)
        {
            decimal exchangeRate = 0;
            if (exchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 0.98m;
            }
            else
            {
                exchangeRate = 0.93m;
            }

            decimal result = Convert(dollar, exchangeRate);
            return result;
        }

        public decimal CalculateFromEurosToUsDollars(decimal euro, DateTime ExchangeRateDate)
        {
            decimal exchangeRate = 0;
            if (ExchangeRateDate == new DateTime(2010, 1, 1))
            {
                exchangeRate = 1.07m;
            }
            else
            {
                exchangeRate = 1.03m;
            }

            decimal result = Convert(euro, exchangeRate);
            return result;
        }

        private decimal Convert(decimal currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

    }
}
