
namespace Fundamentals.For;

class ForClass
{
   public static void Execute ()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine($"Número: {i}");
        }

        List<string> amigos = new List<string> { "Antonio", "Érico", "Samuel" };
        
        
        for (int i = 0; i < amigos.Count; i++)
        {
            Console.WriteLine($"Meu amigo da vez é: {amigos[i]}");
        }
    }
}
