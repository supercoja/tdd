using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornaValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornaValorDivisao()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(4, 2);

            // Assert
            Assert.Equal(2, resultado);
        }


        // Theory pode ser utilizado carregando dados de um excel
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(1, 2, 3)]
        [InlineData(8, 7, 15)]
        [InlineData(35, 40, 75)]
        public void Calculadora_Somar_RetornarValoresSoma(int valor1, int valor2, int total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(valor1, valor2);

            // Assert
            Assert.Equal(total, resultado);
        }

    }
}
