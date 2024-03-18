using System;

public class Serpiente : Animal
{
    public Serpiente() : base("Serpiente", "siseo") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado a la serpiente con ratones.");
    }

    public override void Mover()
    {
        Console.WriteLine("La serpiente se desliza silenciosamente por el suelo.");
    }
}
