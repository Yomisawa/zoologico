using System;

public class Elefante : Animal
{
    public Elefante() : base("Elefante", "barrito") { }

    public override void Alimentar()
    {
        Console.WriteLine("Has alimentado al elefante con vegetales y frutas.");
    }

    public override void Mover()
    {
        Console.WriteLine("El elefante está caminando lentamente.");
    }
}
