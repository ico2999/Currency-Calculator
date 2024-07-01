namespace CurrencyCalculator
{
    public class Calculator
    {
        public decimal Calculate()
        {
            int euro = 100;
            decimal exchangeRate = 0.85m;
            decimal result = euro * exchangeRate;
            return result;
        }

    }
}
