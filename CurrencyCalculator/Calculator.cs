namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal CalculateFromEurosToPounds(int euro)
        {
            decimal exchangeRate = 0.85m;
            decimal result = ExchangeRate(euro, exchangeRate);
            return result;
        }

        public decimal CalculateFromUsDollarsToPounds(int dollars)
        {
            decimal exchangeRate = 0.82m;
            decimal result = ExchangeRate(dollars, exchangeRate);
            return result;
        }

        public decimal CalculateFromPoundsToEuros(int pound)
        {
            decimal exchangeRate = 1.17m;
            decimal result = ExchangeRate(pound, exchangeRate);
            return result;
        }

        public decimal CalculateFromPoundsToUsDollars(int dollar)
        {
            decimal exchangeRate = 1.22m;
            decimal result = ExchangeRate(dollar, exchangeRate);
            return result;
        }

        private decimal ExchangeRate(int currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

    }
}
