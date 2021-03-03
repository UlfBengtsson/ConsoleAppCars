using System;
using Xunit;
using ConsoleAppCars;

namespace ConsoleAppCars.Tests
{
    public class CarTests
    {
        //[Fact]
        //public void Test()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        //}

        [Fact]//annotation
        public void CarInitStageTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            string expectedRegPlate = "ABC123";
            int maxSpeed = 260;
            int startSpeed = 0;

            //Act
            Car car = new Car(brand,model,regPlate,maxSpeed);

            //Assert
            Assert.Equal(brand, car.Brand);
            Assert.Equal(model, car.Model);
            Assert.Equal(expectedRegPlate, car.RegPlate);
            Assert.Equal(maxSpeed, car.MaxSpeedLimit);
            Assert.Equal(startSpeed, car.Speed);
        }

        [Fact]
        public void MaxSpeedLowestTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            int maxSpeed = 1;
            Car car = new Car(brand, model, regPlate, maxSpeed);

            //Act
            int result = car.MaxSpeedLimit;

            //Assert
            Assert.True(result == 1);
        }

        [Fact]
        public void MaxSpeedBelowLowestTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            int maxSpeed = 0;
            Car car = new Car(brand, model, regPlate, maxSpeed);

            //Act
            int result = car.MaxSpeedLimit;

            //Assert
            Assert.NotEqual(0, result);
        }

        [Fact]
        public void MaxSpeedNegativBelowLowestTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            int maxSpeed = -10;
            Car car = new Car(brand, model, regPlate, maxSpeed);

            //Act
            int result = car.MaxSpeedLimit;

            //Assert
            Assert.NotEqual(-10, result);
        }

        [Fact]
        public void SpeedToMaxSpeedTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            int maxSpeed = 10;
            Car car = new Car(brand, model, regPlate, maxSpeed);

            //Act
            car.Speed = maxSpeed;

            //Assert
            Assert.Equal(maxSpeed, car.Speed);
        }

        [Fact]
        public void SpeedOverMaxSpeedTest()
        {
            //Arrange
            string brand = "SAAB";
            string model = "900";
            char[] regPlate = { 'A', 'B', 'C', '1', '2', '3' };
            int maxSpeed = 10;
            Car car = new Car(brand, model, regPlate, maxSpeed);
            int originalSpeed = car.Speed;

            //Act
            car.Speed = 11;

            //Assert
            Assert.Equal(originalSpeed, car.Speed);
        }
    }
}
