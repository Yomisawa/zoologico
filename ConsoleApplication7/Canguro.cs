using System;

public class Canguro : Animal
{
    public Canguro() : base("Canguro", "gruñido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al canguro con hierba y hojas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El canguro está saltando con sus patas traseras.");
    }
}
