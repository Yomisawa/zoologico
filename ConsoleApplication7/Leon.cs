using System;

public class Leon : Animal
{
    public Leon() : base("León", "rugido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al león con carne.");
    }

    public override void Mover()
    {
        Console.WriteLine("El león está caminando majestuosamente.");
    }
}
