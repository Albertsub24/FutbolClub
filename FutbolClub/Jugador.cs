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

    public int NumeroCamiseta { get; set; }
    public Equipo EquipoAsignado { get; set; }
    public string Posicion { get; set; }

    public Jugador(string nombre, string posicion, int numeroCamiseta)
    {
        Nombre = nombre;
        Posicion = posicion;
        NumeroCamiseta = numeroCamiseta;
    }

    public override string ToString()
    {
        return $"{NumeroCamiseta} - {Nombre} ({Posicion})";
    }
}