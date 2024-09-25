namespace CalculadoraTest;

using Calculadora;

public class CalculadoraTest
{
    public Calculadora construirClasse()
    {
        return new Calculadora("01/01/2011");
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarHistorico4Operacoes()
    {
        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(4, 3);
        calc.somar(6, 5);
        calc.somar(4, 1);

        var lista = calc.historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

    [Fact]
    public void TestarHistorico0Operacoes()
    {
        Calculadora calc = construirClasse();

        var lista = calc.historico();
        Assert.Empty(lista);
    }
}