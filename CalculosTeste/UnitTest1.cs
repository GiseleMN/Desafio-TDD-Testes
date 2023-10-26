using Calculos.Models;

namespace CalculosTeste;

public class UnitTest1
{
    public Calculadora construirClass()
    {

        string data = "23/10/2023";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Somar(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Multiplicar(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(9, 5, 4)]
    public void TesteSubtrair(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Subtrair(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(4, 2, 2)]
    public void TesteDividir(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Dividir(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClass();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
            );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClass();

        calc.Somar(2, 2);
        calc.Somar(3, 4);
        calc.Somar(4, 4);
        calc.Somar(5, 5);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}
