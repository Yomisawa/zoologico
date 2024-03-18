using System;

public class Cocodrilo : Animal
{
    public Cocodrilo() : base("Cocodrilo", "rugido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al cocodrilo con carne fresca.");
    }

    public override void Mover()
    {
        Console.WriteLine("El cocodrilo está acechando en el agua.");
    }
}
