using System;
using Xunit;
using XUnitSample;

namespace CalculatorUnitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Be_able_to_add_two_numbers()
        {
            var calc = new Calculator();
            //Arrange
            int number1 = 5;
            int number2 = 15;
            var containsValues = new [] { 3, 5,7, -10 };
            var doesNotContains = new [] { 2, 4, 6 };

            //Act
            int result = calc.Addition(number1, number2);

            //Assert
            Assert.Equal(20, result);
            Assert.NotEqual(0, result);

            Assert.Contains<int>(containsValues, value => value == result);
            Assert.DoesNotContain<int>(doesNotContains, value => value == result);

            Assert.True(result == 20);
            Assert.False(result == 0);

            Assert.Matches("sa{2}t", "saat");
            Assert.DoesNotMatch("sa{2}t", "samet");

            Assert.NotEmpty(containsValues);
            Assert.Null(new Calculator());
            var exception = Assert.Throws<DivideByZeroException>(() => calc.Divide(1, 0));

        }
    }
}
