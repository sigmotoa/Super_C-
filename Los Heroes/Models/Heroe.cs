namespace Los_Heroes.Models;

public class Heroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<Poder> Poderes;
    public bool Volar;

    public Heroe(string nombre, int id)
    {
        Id = id;
        Nombre = nombre;
        Poderes = new List<Poder>();
    }
    
    public void MostrarHeroe()
    {
        Console.WriteLine($"{Id}" +
                          $"\n{Nombre}" +
                          $"\n{IdentidadSecreta}" +
                          $"\n{Ciudad}" +
                          $"\nVolar {Volar}\nPoderes:");
        ListaPoderes();
    }

    private void ListaPoderes()
    {
        foreach (var unPoder in Poderes)
        {
            Console.WriteLine($"\t{unPoder.Nombre}");
        }
    }
}