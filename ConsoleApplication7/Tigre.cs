using System;

public class Tigre : Animal
{
    public Tigre() : base("Tigre", "rugido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al tigre con carne.");
    }

    public override void Mover()
    {
        Console.WriteLine("El tigre está acechando en la selva.");
    }
}
