// See https://aka.ms/new-console-template for more information


var superMan = new Heroe();
superMan.Id = 1;
superMan.Nombre = "SuperMan";
superMan.IdentidadSecreta = "Clark Kent";
superMan.Ciudad = "Metropolis";
superMan.Poderes = 
    new[] {
        "Super Fuerza", 
        "Rayo Laser", 
        "Super Salto", 
        "Super Velocidad" };
superMan.Volar = true;

superMan.MostrarHeroe();



class Heroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] Poderes;
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
        for (int i = 0; i < Poderes.Length; i++)
        {
            Console.WriteLine($"\t{Poderes[i]}");
        }
    }
}
