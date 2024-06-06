
using System;
using System.Collections.Generic;

namespace FutbolClub
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador)
        {
                Jugadores.Add(jugador);
        }

        public void ListarJugadores()
        {
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }
}
