public class Carro:Veiculo,IAceleravel, IFreavel
{
    public Carro(string marca, string modelo):base(marca, modelo)
    {

    }
    public override void Ligar()
    {
        System.Console.WriteLine($"O carro da marca {Marca} e modelo {Modelo} esta ligado");
    }
    public void Acelerar()
    {
        System.Console.WriteLine("O carro acelerou");
    }
    public void Frear()
    {
        System.Console.WriteLine("O carro freou");
    }

}