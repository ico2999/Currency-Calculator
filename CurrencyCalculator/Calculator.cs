namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal CalculateFromEurosToPounds()
        {
            int euro = 100;
            decimal exchangeRate = 0.85m;
            decimal result = euro * exchangeRate;
            return result;
        }

        public decimal CalculateFromUsDollarsToPounds()
        {
            int usDollars = 100;
            decimal exchangeRate = 0.82m;
            decimal result = usDollars * exchangeRate;
            return result;
        }

    }
}
