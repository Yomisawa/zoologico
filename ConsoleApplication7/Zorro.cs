using System;

public class Zorro : Animal
{
    public Zorro() : base("Zorro", "aullido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al zorro con carne cruda.");
    }

    public override void Mover()
    {
        Console.WriteLine("El zorro está husmeando en busca de comida.");
    }
}
