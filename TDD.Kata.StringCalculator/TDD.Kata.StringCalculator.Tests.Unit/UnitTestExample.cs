//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace TDD.Kata.StringCalculator.Tests.Unit
{

    public class UnitTestExample
    {
        private Calculator Target;

        public UnitTestExample()
        {
            this.Target = new Calculator();
        }

        [Fact]
        public void Example()
        {
            //Arrange
            //Your set up!.
            string numbers = string.Empty;

            //Act
            //Your principal action to test.
            int resultado = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(0, resultado);

        }





    }
}
