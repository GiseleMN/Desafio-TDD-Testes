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
    [InlineData(6, 2, 8)]
    [InlineData(4, 5, 9)]
    [InlineData(20, 5, 25)]
    public void TesteSomar(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Somar(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    [InlineData(7, 7, 49)]
    public void TesteMultiplicar(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Multiplicar(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(5, 7, -2)]
    [InlineData(9, 5, 4)]
    [InlineData(20, 5, 15)]
    public void TesteSubtrair(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Subtrair(x, y);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(4, 2, 2)]
    [InlineData(5, 2, 2.5)]
    [InlineData(10, 3, 3.33)]
    public void TesteDividir(int x, int y, int resultado)
    {
        Calculadora calc = construirClass();

        double resultadoCalculadora = calc.Dividir(x, y);
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
