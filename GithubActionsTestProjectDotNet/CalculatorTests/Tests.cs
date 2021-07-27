using Calculator;
using Xunit;

namespace CalculatorTests
{
    public class Tests
    {
        [Fact]
        public void It_Adds_Two_Integers()
        {
            //Arrange
            var a = 3;
            var b = 4;

            //Act
            var result = SuperCalculator.Add(a, b);
            
            //Assert
            Assert.True(result == 7);
        }

        [Fact]
        public void It_Subtracts_Two_Integers()
        {
            //Arrange
            var a = 5;
            var b = 4;

            //Act
            var result = SuperCalculator.Subtract(a, b);

            //Assert
            Assert.True(result == 1);
        }

        [Fact]
        public void It_Multiplies_Two_Integers()
        {
            //Arrange
            var a = 3;
            var b = 4;

            //Act
            var result = SuperCalculator.Multiply(a, b);

            //Assert
            Assert.True(result == 12);
        }

        [Fact]
        public void It_Divides_Two_Integers()
        {
            //Arrange
            var a = 3;
            var b = 4;

            //Act
            var result = SuperCalculator.Divide(a, b);

            //Assert
            Assert.True(result == 0.75);
        }



    }
}
