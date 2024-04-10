namespace Los_Heroes.Models;

public class Poder
{
    
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public Poder()
    {
        
    }
    
    public Poder(string nombre)
    {
        Nombre = nombre;
        Nivel = NivelPoder.NivelUno;
    }
}
