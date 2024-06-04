using System;
using System.Collections.Generic;

internal class Equipo
{
	int Id { get; set; }
	string Nombre { get; set; }
	List<Jugador> jugadores;
	public Equipo(int id, string nombre) 
	{
		Id = id;
		Nombre = nombre;
		List < Jugador > = new List<Jugador>();
	}
    public void AddJugador(Jugador jugador)
    {
        jugadores.Add(jugador);
	}
	public string ViewJugadores()
	{
		string salida = "";
		foreach (Jugador jugador in jugadores)
		{
			salida += "\n"+jugador.ToString();
		}
		return salida;
	}
    public override string ToString()
    {
        return this.Nombre+ViewJugadores();
    }
}