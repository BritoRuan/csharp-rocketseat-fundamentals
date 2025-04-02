using Fundamentals.Classes;

namespace Fundamentals;

class Program 
{
    static void Main()
    {
        //carro.Cor = Enums.Cor.Azul;
        //carro.Comprado = new DateOnly(2024, 12, 25);

        //var carro = new Carro
        //{
        //    Cor = Enums.Cor.Azul,
        //    Comprado = new DateOnly(2024, 12, 25),
        //    Chassi = "451 X7ngSF L2 CT7763",
        //};

        Carro meuCarro = new("451 X7ngSF L2 CT7763", new DateOnly(2024, 12, 25) , Enums.Cor.Azul);

        meuCarro.CompradoEm();
    }
}