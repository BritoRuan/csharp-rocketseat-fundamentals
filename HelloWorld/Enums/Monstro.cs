
namespace HelloWorld.Enums;

class Monstro
{
    enum NivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }

    NivelDeDificuldade nivel = NivelDeDificuldade.Alto; // Console.WriteLine(nivel); // Alto
}
