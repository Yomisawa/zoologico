using System;
using System.Collections.Generic;

// Definición de la clase Animal
public abstract class Animal
{
    public string Nombre { get; set; }
    public string Sonido { get; set; }

    protected Animal(string nombre, string sonido)
    {
        Nombre = nombre;
        Sonido = sonido;
    }

    public abstract void Alimentar();
    public abstract void Mover();
    public void EmitirSonido()
    {
        Console.WriteLine(string.Format("{0} hace '{1}'", Nombre, Sonido));
    }

}

// Clase Zoologico 
public class Zoologico
{
    private List<Animal> animales = new List<Animal>();

    public void AgregarAnimal(Animal animal)
    {
        animales.Add(animal);
    }

    public void InteractuarConAnimales()
    {
        foreach (var animal in animales)
        {
            animal.Alimentar();
            animal.Mover();
            animal.EmitirSonido();
        }
    }

    public int CantidadAnimales()
    {
        return animales.Count;
    }

    public Animal ObtenerAnimal(int indice)
    {
        return animales[indice];
    }
}


// Programa principal

class Program
{
    static void Main()
    {
        Zoologico miZoologico = new Zoologico();

        // Agregar animales
        miZoologico.AgregarAnimal(new Leon());
        miZoologico.AgregarAnimal(new Elefante());
        miZoologico.AgregarAnimal(new Mono());
        miZoologico.AgregarAnimal(new Perro());
        miZoologico.AgregarAnimal(new Gato());
        miZoologico.AgregarAnimal(new Pajaro());
        miZoologico.AgregarAnimal(new Pez());
        miZoologico.AgregarAnimal(new Caballo());
        miZoologico.AgregarAnimal(new Cocodrilo());
        miZoologico.AgregarAnimal(new Oso());
        miZoologico.AgregarAnimal(new Tigre());
        miZoologico.AgregarAnimal(new Serpiente());
        miZoologico.AgregarAnimal(new Zorro());
        miZoologico.AgregarAnimal(new Canguro());
        miZoologico.AgregarAnimal(new Lince());

        // Mostrar listado de animales
        Console.WriteLine("Lista de animales:");
        ListarAnimales(miZoologico);

        // Permitir al usuario seleccionar un animal
        Console.Write("Seleccione el número de un animal para interactuar: ");
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > miZoologico.CantidadAnimales())
        {
            Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
            Console.Write("Seleccione el número de un animal para interactuar: ");
        }

        // Obtener el animal seleccionado
        Animal animalSeleccionado = miZoologico.ObtenerAnimal(opcion - 1);

        // Mostrar las opciones de interacción
        Console.WriteLine("Interacciones para " + animalSeleccionado.Nombre + ":");
        Console.WriteLine("1. Escuchar al animal");
        Console.WriteLine("2. Alimentar al animal");
        Console.WriteLine("3. Observar al animal");

        // Permitir al usuario seleccionar una acción
        Console.Write("Seleccione el número de una acción: ");
        int accion;
        while (!int.TryParse(Console.ReadLine(), out accion) || accion < 1 || accion > 3)
        {
            Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
            Console.Write("Seleccione el número de una acción: ");
        }

        // Realizar la acción seleccionada
        switch (accion)
        {
            case 1:
                Console.WriteLine("Escuchando al animal:");
                animalSeleccionado.EmitirSonido();
                break;
            case 2:
                Console.WriteLine("Alimentando al animal:");
                animalSeleccionado.Alimentar();
                break;
            case 3:
                Console.WriteLine("Observando al animal:");
                animalSeleccionado.Mover();
                break;
        }

        // Esperar entrada del usuario para que la consola no se cierre automáticamente
        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();
    }

    // Método para listar los animales disponibles en el zoológico
static void ListarAnimales(Zoologico zoologico)
{
    for (int i = 0; i < zoologico.CantidadAnimales(); i++)
    {
        Console.WriteLine((i + 1) + ". " + zoologico.ObtenerAnimal(i).Nombre);
    }
}
}