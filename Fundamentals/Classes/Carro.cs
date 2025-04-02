using Fundamentals.Enums;

namespace Fundamentals.Classes;
public class Carro
{
    public string Chassi { get; set; }

    public DateOnly Comprado { get; set; }

    public Cor Cor { get; set; }

    public void NumeroDoChassi() => Console.WriteLine(Chassi);
    public void CompradoEm() => Console.WriteLine(Comprado);
    public void CorDoCarro() => Console.WriteLine(Cor);


    public Carro(String chassi, DateOnly comprado, Cor cor)
    {
        Chassi = chassi;
        Comprado = comprado;
        Cor = cor;
    }
}