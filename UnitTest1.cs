using Xunit;
using ConsoleApp4;
using System;

namespace ValutaAtvalto.Tests
{
    public class ValutaAtvaltoTests
    {
        [Fact]
        public void HufToDollar_ShouldReturnCorrectValue()
        {
            double result = Class1.ValutaÁtváltó.HufToDollar(300);
            Assert.Equal(1.00, result, 2);
        }

        [Fact]
        public void HufToEur_ShouldReturnCorrectValue()
        {
            double result = Class1.ValutaÁtváltó.HufToEur(360);
            Assert.Equal(1.00, result, 2);
        }

        [Fact]
        public void DollarToHuf_ShouldReturnCorrectValue()
        {
            double result = Class1.ValutaÁtváltó.DollarToHuf(1);
            Assert.Equal(300, result, 2);
        }

        [Fact]
        public void EurToHuf_ShouldReturnCorrectValue()
        {
            double result = Class1.ValutaÁtváltó.EurToHuf(1);
            Assert.Equal(360, result, 2);
        }

        [Theory]
        [InlineData(600, 2.00, 1.67)]
        [InlineData(150, 0.50, 0.42)]
        [InlineData(900, 3.00, 2.50)]
        public void HufToDollarAndEurShouldReturnCorrectValue(double huf, double expectedDollar, double expectedEur)
        {
            double resultDollar = Class1.ValutaÁtváltó.HufToDollar(huf);
            double resultEur = Class1.ValutaÁtváltó.HufToEur(huf);
            Assert.Equal(expectedDollar, resultDollar, 2);
            Assert.Equal(expectedEur, resultEur, 2);
        }
    }
}
