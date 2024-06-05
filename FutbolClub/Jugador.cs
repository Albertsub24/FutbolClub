using System;
using System.Collections.Generic;
using System.Linq;

public class Jugador
{
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

    public Jugador(string nombre, string posicion, string numeroCamiseta)
    {
        Nombre = nombre;
        Posicion = posicion;
        NumeroCamiseta = numeroCamiseta;
    }

           public override string ToString()
        {
            return $"{NumeroCamiseta} - {Nombre} ({Posicion})";
        }
    public Jugador CrearJugador(int id, string nombre, string posicion, string numeroCamiseta, Equipo equipoAsignado) =>
        new Jugador(Id, Nombre, Posicion, NumeroCamiseta, EquipoAsignado);
    public Jugador CambiarPosicion(Jugador jugador, string posicion)
    {
        if (!posiciones.Contains(posicion))
            posiciones.Add();
        jugador.Posicion = posicion;
        return jugador;
    }
    
}
