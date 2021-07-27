using Calculator;
using Xunit;

namespace CalculatorTests
{
    public class AdditionTests
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
    }
}
