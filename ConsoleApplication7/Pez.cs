using System;

public class Pez : Animal
{
    public Pez() : base("Pez", "burbujeo") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al pez con escamas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El pez está nadando en el acuario.");
    }
}
