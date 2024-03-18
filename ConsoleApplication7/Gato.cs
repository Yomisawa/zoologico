using System;

public class Gato : Animal
{
    public Gato() : base("Gato", "maullido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al gato con comida para gatos.");
    }

    public override void Mover()
    {
        Console.WriteLine("El gato está saltando por los muebles.");
    }
}
