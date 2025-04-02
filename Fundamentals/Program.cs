using Fundamentals.Funcoes;

namespace Fundamentals;

class Program 
{
    static void Main()
    {
      OperacoesMatematicas operacoesMatematicas = new OperacoesMatematicas();

      (int resultado, string nome) = operacoesMatematicas.Adicionar(10, 20);

      Console.WriteLine(resultado);
      Console.WriteLine(nome);
    }
}