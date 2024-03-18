using System;

public class Oso : Animal
{
    public Oso() : base("Oso", "rugido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al oso con miel.");
    }

    public override void Mover()
    {
        Console.WriteLine("El oso está caminando por el bosque.");
    }
}
