
using Fundamentals.Enums;

namespace Fundamentals.Switch;

class SwitchCase
{
    public static void Execute()
    {
        string name = "Ruan";
        int idade = 20;

        // Switch com variável 
        
        string resultado = idade switch
        {
            10 => "Idade é 10",
            20 => "Idade é 20",
            _ => "Idade não é 10 nem 20"
        };

        Console.WriteLine(resultado);


        Cor corFavorita = Cor.Azul;
        
        switch(corFavorita)
        {
            case Cor.Azul:
                {
                    Console.WriteLine("A cor favorita é azul");
                }
                break;

            case Cor.Vermelho:
                {
                    Console.WriteLine("A cor favorita é vermelho");
                }
                break;
            default:
                {
                    Console.WriteLine("A cor favorita é outra");
                }
                break;
        }
    }
}
