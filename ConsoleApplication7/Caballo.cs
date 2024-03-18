using System;

public class Caballo : Animal
{
    public Caballo() : base("Caballo", "relincho") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al caballo con heno.");
    }

    public override void Mover()
    {
        Console.WriteLine("El caballo está trotando en el campo.");
    }
}
