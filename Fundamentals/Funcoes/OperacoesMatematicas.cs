
namespace Fundamentals.Funcoes;

public class OperacoesMatematicas
{
    public (int resultadoDaAdicao, string autor) Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        return (resultado, "Ruan");
    }

    public void Opcional(int valor1, int valor2 = 20)
    {
        Console.WriteLine(valor1 + valor2);
    }
}
