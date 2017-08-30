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
        public void Retorna_Cero_Con_string_vacio()
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

        [Fact]
        public void Retorna_Uno_Con_string_Uno()
        {
            //Arrange
            //Your set up!.
            string numbers = "1";

            //Act
            //Your principal action to test.
            int resultado = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(1, resultado);

        }

        [Fact]
        public void Retorna_La_Suma_si_se_pasan_varios_nros_separador_por_comas()
        {
            //Arrange
            //Your set up!.
            string numbers = "1,2";

            //Act
            //Your principal action to test.
            int resultado = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(3, resultado);

        }

       /* [Fact]
        public void Retorna_La_Suma_si_eese_pasan_varios_nros_separador_por_comas()
        {
            //Arrange
            //Your set up!.
            string numbers = "1,2,5";

            //Act
            //Your principal action to test.
            int resultado = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(8, resultado);

        }
        */




    }
}
