namespace CurrencyCalculator;

public class CurrencyData
{
	public CurrencyData(CurrencyTypeEnum currencyFrom, CurrencyTypeEnum currencyTo, DateTime exchangeRateDate, decimal exchangeRate)
	{
		CurrencyFrom = currencyFrom;
		CurrencyTo = currencyTo;
		ExchangeRateDate = exchangeRateDate;
		ExchangeRate = exchangeRate;
	}

	public CurrencyTypeEnum CurrencyFrom { get; }

	public CurrencyTypeEnum CurrencyTo { get; }

	public DateTime ExchangeRateDate { get; }

	public decimal ExchangeRate { get; }

}