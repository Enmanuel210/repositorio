using Xunit;

namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void TestSumar()
        {
            var calc = new Calculadora();
            int resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TestRestar()
        {
            var calc = new Calculadora();
            int resultado = calc.Restar(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void TestMultiplicar()
        {
            var calc = new Calculadora();
            int resultado = calc.Multiplicar(3, 4);
            Assert.Equal(12, resultado);
        }

        [Fact]
        public void TestDividir()
        {
            var calc = new Calculadora();
            int resultado = calc.Dividir(10, 2);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TestDivisionPorCero()
        {
            var calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(5, 0));
        }
    }
}
