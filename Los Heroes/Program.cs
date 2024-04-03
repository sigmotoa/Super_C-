// See https://aka.ms/new-console-template for more information


var superMan = new Heroe();
superMan.Id = 1;
superMan.Nombre = "SuperMan";
superMan.IdentidadSecreta = "Clark Kent";
superMan.Ciudad = "Metropolis";
superMan.Poderes = new List<Poder>();

superMan.Volar = true;


var Fuerza = new Poder();
Fuerza.Nombre = "Super Fuerza";
Fuerza.Descripcion = "Fuerza muy fuerte";
Fuerza.Nivel = NivelPoder.NivelDos;

var Velocidad = new Poder();
Velocidad.Nombre = "Super Velocidad";
Velocidad.Descripcion = "Ser muy rapido, mas que todos";
Velocidad.Nivel = NivelPoder.NivelDos;

superMan.Poderes.Add(Fuerza);
superMan.Poderes.Add(Velocidad);

superMan.MostrarHeroe();
class Poder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}


class Heroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<Poder> Poderes;
    public bool Volar;

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