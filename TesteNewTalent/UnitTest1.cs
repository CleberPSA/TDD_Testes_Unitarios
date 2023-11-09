using NewTalents;
using System;
using Xunit;

namespace TesteNewTalent
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "09/11/2023";
            Calculadora calc = new Calculadora("09/11/2023");
            return calc;

        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Somar(x, y);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Multiplicar(x, y);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(7, 5, 2)]
        public void TestSubtrair(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Subtracao(x, y);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        public void TestDividir(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = (int)calc.Dividir(x, y);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        public void TestarHistorico()

        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(1, 5);
            calc.Somar(1, 3);
            calc.Somar(1, 4);

            var lista = calc.ListaHistorico();

            Assert.NotEmpty(calc.ListaHistorico());
            Assert.Equal(3, lista.Count);
        }


    }
}


