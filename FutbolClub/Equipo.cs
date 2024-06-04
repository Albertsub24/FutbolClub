using System;
using System.Collections.Generic;

namespace FutbolClub
{
	public class Equipo
	{
		int Id { get; set; }
		string Nombre { get; set; }
		List<Jugador> jugadores;
		public Equipo(int id, string nombre)
		{
			Id = id;
			Nombre = nombre;
			List <Jugador> jugadores = new List<Jugador>();
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
				salida += "\n" + jugador.ToString();
			}
			return salida;
		}
		public override string ToString()
		{
			return this.Nombre + ViewJugadores();
		}
	}
}