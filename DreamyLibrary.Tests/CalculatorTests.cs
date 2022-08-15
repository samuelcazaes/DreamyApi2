using Autofac.Extras.Moq;
using DreamyApi2.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DreamyApi.Tests
{
    public class CalculatorTests
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 6, 11)]
        [InlineData(10, 10, 20)]
        public void Somar_DeveSomar(int a, int b, int expected)
        {
            //Arrange

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Somar(a, b);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(6, 5, 1)]
        [InlineData(10, 10, 0)]
        public void Somar_DeveDiminuir(int a, int b, int expected)
        {
            //Arrange

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Diminuir(a, b);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 6, 30)]
        [InlineData(10, 10, 100)]
        public void Somar_DeveMultiplicar(int a, int b, int expected)
        {
            //Arrange

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Multiplicar(a, b);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        [InlineData(8, 4, 2)]
        [InlineData(10, 10, 1)]
        public void Somar_DeveDividir(int a, int b, int expected)
        {
            //Arrange

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Dividir(a, b);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Somar_FactDeveDividir()
        {
            //Arrange

            int a = 50;
            int b = 25;
            double expected = 2;

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Dividir(a, b);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Somar_FactInDeveDividir()
        {
            //Arrange

            CalculatorRepository _ctr = new CalculatorRepository();

            // Act

            int actual = _ctr.Dividir(50, 25);

            // Assert

            Assert.Equal(2, actual);
        }
    }
}
