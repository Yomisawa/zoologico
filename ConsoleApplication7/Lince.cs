using System;

public class Lince : Animal
{
    public Lince() : base("Lince", "ronroneo") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al lince con carne fresca.");
    }

    public override void Mover()
    {
        Console.WriteLine("El lince está acechando sigilosamente.");
    }
}
