using System;

public class Pajaro : Animal
{
    public Pajaro() : base("Pájaro", "canto") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al pájaro con semillas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El pájaro está volando en el cielo.");
    }
}
