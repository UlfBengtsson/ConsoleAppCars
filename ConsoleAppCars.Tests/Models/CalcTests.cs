using System;
using Xunit;
using ConsoleAppCars;

namespace ConsoleAppCars.Tests
{
    public class CalcTests
    {
        //[Fact]
        //public void Test()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        //}

        [Fact]
        public void SimpleAddTest()
        {
            //Arrange
            double number1 = 2.3;
            double number2 = 3.2;
            double expected = 5.5;
            double result;

            //Act
            result = Calc.Add(number1, number2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TrippleAddTest()
        {
            //Arrange
            double number1 = 2.3;
            double number2 = 3.2;
            double number3 = 0.2;
            double expected = 5.7;
            double result;

            //Act
            result = Calc.Add(number1, number2, number3);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3.3, 2.2, 5.5)]
        [InlineData(3.3, 4.7, 8.0)]
        [InlineData(1.1, 2.2, 3.3)]
        [InlineData(5.0, 2.0, 7.0)]
        public void ManyAddNumbersTest(double numberA, double numberB, double expected)
        {
            //Arrange
            double result;

            //Act
            result = Calc.Add(numberA, numberB);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void AddArrayNumbersTest()
        {
            //Arrange
            double[] testNumbers = { 3, 4, 7, 6 };
            double expected = 20;
            double result;

            //Act
            result = Calc.Add(testNumbers);

            //Assert
            Assert.Equal(expected, result, 2);
        }
    }
}
