using System;
using System.Collections.Generic;

public class Equipo
{
	public Equipo()
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
				salida += jugador.ToString();
			} 
		}
    }

}