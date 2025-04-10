
namespace Fundamentals.Jump;

class ReturnClass
{
    public static void Execute()
    {
        var numero = 0;


        while (numero < 10)
        {
            // Dentro de um loop o return funciona como um break;
            // A diferença é que o return não só para o loop, mas também encerra o método
            if (numero == 5)
            {
                return;
            }

            numero++;

            Console.WriteLine(numero);
        }
    }

    public static string Teste(int numero)
    {
        Console.WriteLine("Teste 1");

        if(numero == 5)
        {
            Console.WriteLine("Teste 2");
            return "Ruan";
        }

        Console.WriteLine("Teste 3");

        return "Brito";
    }
}
