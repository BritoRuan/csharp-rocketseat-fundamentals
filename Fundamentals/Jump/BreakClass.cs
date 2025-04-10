
namespace Fundamentals.Jump;

class BreakClass
{
    public static void Execute()
    {
        var numero = 0;

        // Loop que vai de 0 a 99
        while (numero < 100)
        {
            // Se o número for 5, sai do loop
            if (numero == 5)
            {
                break;
            }

            Console.WriteLine(numero);
            numero++;
        } 
    }
}
