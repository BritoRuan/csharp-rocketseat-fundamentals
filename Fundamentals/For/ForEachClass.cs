
namespace Fundamentals.For;

class ForEachClass
{
    public static void Execute()
    {
        var amigos = new List<string> { "Antonio", "Érico", "Samuel" };

        Console.WriteLine("Usando o foreach");
        foreach (var amigo in amigos)
        {
            Console.WriteLine($"Meu amigo da vez é: {amigo}");
        }


        Console.WriteLine("Usando o for i");

        for (int i = 0; i < amigos.Count; i++)
        {
            Console.WriteLine($"Meu amigo da vez é: {amigos[i]}");
        }

        var dicionario = new Dictionary<string, string>();

        dicionario.Add("Nome1", "Antonio");
        dicionario.Add("Nome2", "Samuel");
        dicionario.Add("Nome3", "Érico");

        
        Console.WriteLine("Usando o foreach no dicionário");
        foreach (var item in dicionario)
        {
            Console.WriteLine($"Meu amigo da vez é: {item.Key}");
            Console.WriteLine($"Meu amigo da vez é: {item.Value}");
        }
    }
}
