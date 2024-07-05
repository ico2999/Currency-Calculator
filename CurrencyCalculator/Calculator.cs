using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using Microsoft.VisualBasic;

namespace CurrencyCalculator
{
    public class Calculator
    {
	    private List<CurrencyData> _currencyData = new List<CurrencyData>
	    {
		    new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Eur, new DateTime(2010, 1, 1), 1.17m),
		    new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Eur, new DateTime(2020, 1, 1), 1.09m),
		    new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Usd, new DateTime(2010, 1, 1), 1.22m),
		    new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Usd, new DateTime(2020, 1, 1), 1.18m),
		    new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Gbp, new DateTime(2010, 1, 1), 0.85m),
		    new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Gbp, new DateTime(2020, 1, 1), 0.8m),
		    new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Usd, new DateTime(2010, 1, 1), 1.07m),
		    new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Usd, new DateTime(2020, 1, 1), 1.03m),
		    new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Gbp, new DateTime(2010, 1, 1), 0.82m),
		    new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Gbp, new DateTime(2020, 1, 1), 0.87m),
		    new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Eur, new DateTime(2010, 1, 1), 0.98m),
		    new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Eur, new DateTime(2020, 1, 1), 0.93m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Gbp, new DateTime(2010, 1, 1), 0.78m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Gbp, new DateTime(2020, 1, 1), 0.75m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Usd, new DateTime(2010, 1, 1), 0.93m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Usd, new DateTime(2020, 1, 1), 0.91m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Eur, new DateTime(2010, 1, 1), 0.88m),
		    new CurrencyData(CurrencyTypeEnum.Cad, CurrencyTypeEnum.Eur, new DateTime(2020, 1, 1), 0.83m),
		    new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Cad, new DateTime(2010, 1, 1), 0.92m),
			new CurrencyData(CurrencyTypeEnum.Gbp, CurrencyTypeEnum.Cad, new DateTime(2020, 1, 1), 0.9m),
			new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Cad, new DateTime(2010, 1, 1), 0.76m),
			new CurrencyData(CurrencyTypeEnum.Eur, CurrencyTypeEnum.Cad, new DateTime(2020, 1, 1), 0.88m),
			new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Cad, new DateTime(2010, 1, 1), 0.97m),
			new CurrencyData(CurrencyTypeEnum.Usd, CurrencyTypeEnum.Cad, new DateTime(2020, 1, 1), 0.95m),
	    };

        private decimal Convert(decimal currencyValue, decimal exchangeRate)
        {
            return currencyValue * exchangeRate;
        }

        public decimal ConvertCurrency(decimal amountFrom, CurrencyTypeEnum currencyFrom, CurrencyTypeEnum currencyTo, DateTime exchangeRateDate)
        {
			CurrencyData currencyData = _currencyData.FirstOrDefault(c =>
				c.CurrencyFrom == currencyFrom && c.CurrencyTo == currencyTo && c.ExchangeRateDate == exchangeRateDate);

			if (currencyData != null)
			{
				decimal exchangeRate = currencyData.ExchangeRate;
				decimal result = Convert(amountFrom, exchangeRate);
				return result;

			}
			else
			{
				throw new NullReferenceException("Can't find data for this currency conversion");
			}
        }
    }
}