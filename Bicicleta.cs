public class Bicicleta:Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo):base(marca, modelo)
    {

    }
    public override void Ligar()
    {
        System.Console.WriteLine("a bike ta ligada");
    }
    public void Acelerar()
    {
        System.Console.WriteLine("Bicicleta ta pedalando mais rapido");
    }
}