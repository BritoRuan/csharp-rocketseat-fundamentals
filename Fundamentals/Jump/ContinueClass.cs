
namespace Fundamentals.Jump;

class ContinueClass
{
    public static void Execute()
    {
        var numero = 0;

        // Loop que vai de 0 a 10
        while (numero < 10)
        {
            //numero++;

            // Ele pula o que está abaixo do continue e volta para o início do loop
            if (numero == 5)
            {
                continue;
            }

            numero++;

            Console.WriteLine(numero);
        }
    }
}