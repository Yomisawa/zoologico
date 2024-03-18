using System;

public class Mono : Animal
{
    public Mono() : base("Mono", "chillido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al mono con bananas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El mono está saltando entre los árboles.");
    }
}
