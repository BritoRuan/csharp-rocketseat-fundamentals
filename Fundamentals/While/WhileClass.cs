
namespace Fundamentals.While;

class WhileClass
{
    public static void Execute()
    {
        var idade = 3;

        // Começa com uma checagem
        while (idade < 3)
        {
            Console.WriteLine("Você é menor de idade!");

            idade++;
        }

        // Executa pelo menos uma vez e depois checar no final
        do
        {
            Console.WriteLine("Você é maior de idade!");
            idade++;
        } while (idade < 3);
    }
}
