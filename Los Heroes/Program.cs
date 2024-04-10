// See https://aka.ms/new-console-template for more information

using Los_Heroes.Models;

var superMan = new Heroe(nombre:"SuperMan",id:1);
var flash = new Heroe("Flash", 2);

superMan.Id = 1;
superMan.Nombre = "SuperMan";
superMan.IdentidadSecreta = "Clark Kent";
superMan.Ciudad = "Metropolis";
superMan.Poderes = new List<Poder>();

superMan.Volar = true;

var LeerMente = new Poder("Leer la mente");


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
superMan.Poderes.Add(LeerMente);

superMan.MostrarHeroe();
flash.MostrarHeroe();

public enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}


