namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal CalculateFromEurosToPounds()
        {
            int euro = 100;
            decimal exchangeRate = 0.85m;
            decimal result = ExchangeRate(euro, exchangeRate);
            return result;
        }

        public decimal CalculateFromUsDollarsToPounds()
        {
            int usDollars = 100;
            decimal exchangeRate = 0.82m;
            decimal result = ExchangeRate(usDollars, exchangeRate);
            return result;
        }

        public decimal CalculateFromPoundsToEuros()
        {
            int pound = 100;
            decimal exchangeRate = 1.17m;
            decimal result = ExchangeRate(pound, exchangeRate);
            return result;

        }

        public decimal CalculateFromPoundsToUsDollars()
        {
            int pound = 100;
            decimal exchangeRate = 1.22m;
            decimal result = ExchangeRate(pound, exchangeRate);
            return result;
        }

        private decimal ExchangeRate(int currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

    }
}
