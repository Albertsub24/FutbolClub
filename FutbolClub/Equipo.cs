using System;
using System.Collections.Generic;

public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    List<Jugador> Jugadores;

    public Equipo(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
        List<Jugador> Jugadores = new List<Jugador>();
    }

    public void AddJugador(Jugador jugador)
    {
        Jugadores.Add(jugador);
    }

    public string ViewJugadores()
    {
        string salida = "";
        foreach (Jugador jugador in Jugadores)
        {
            salida += "\n" + jugador.ToString();
        }

        return salida;
    }

    public override string ToString()
    {
        return this.Nombre + ViewJugadores();
    }
}