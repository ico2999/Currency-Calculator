using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using CurrencyCalculator;
using CurrencyCalculator.API;
using FluentAssertions;

namespace CurrencyCalculatorAPI.Unit
{
    public class ApiCalculatorShould
    {
        [Fact]
        public void GetEurosToPounds()
        {
            CurrencyConverterController controller = new CurrencyConverterController();
            decimal result = controller.GetEurosToPounds();
            result.Should().Be(85);
        }
    }
}