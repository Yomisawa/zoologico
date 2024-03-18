using System;

public class Perro : Animal
{
    public Perro() : base("Perro", "ladrido") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al perro con croquetas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El perro está corriendo en el parque.");
    }
}
