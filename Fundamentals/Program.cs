
using Fundamentals.For;
using Fundamentals.Jump;
using Fundamentals.While;

namespace Fundamentals;

class Program 
{
    static void Main()
    {
        ForClass.Execute();
        ForEachClass.Execute();
        WhileClass.Execute();
        BreakClass.Execute();
        ContinueClass.Execute();
        ReturnClass.Execute();
        var texto = ReturnClass.Teste(5);
        Console.WriteLine(texto);
    }
}