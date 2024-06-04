using System;
using System.Collections.Generic;

public class Jugador
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    private HashSet<string> posiciones = new HashSet<string>()
    {
        "Delantero",
        "Defensa",
        "Portero",
        "Mediocampo"
    };
    public string NumeroCamiseta { get; set; }
    public Equipo EquipoAsignado { get; set; }
    public string Posicion { get; set; }

    public Jugador(int id, string nombre, string posicion, string numeroCamiseta, Equipo equipoAsignado)
    {
        Id = id;
        Nombre = nombre;
        Posicion = posicion;
        NumeroCamiseta = numeroCamiseta;
        EquipoAsignado = equipoAsignado;
    }
    
    public Jugador CrearJugador(int id, string nombre, string posicion, string numeroCamiseta, Equipo equipoAsignado) =>
        new Jugador(Id, Nombre, Posicion, NumeroCamiseta, EquipoAsignado);

    public Jugador CambiarPosicion(Jugador jugador, string posicion)
    {
        jugador.Posicion = posicion;
        return jugador;
    }
    
}
