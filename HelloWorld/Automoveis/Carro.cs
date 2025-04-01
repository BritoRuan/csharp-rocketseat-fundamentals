namespace HelloWorld.Automoveis;
class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro ligado");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado");
    }

    internal void NumeroDoMotor()
    {
        Console.WriteLine("V8 6.0L");
    }

    private void NumeroDoChassi()
    {
        Console.WriteLine("8LS 4g323v lV 0t5676");
    }
}
