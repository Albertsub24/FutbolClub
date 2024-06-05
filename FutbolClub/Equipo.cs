// ClubFutbol/Equipo.cs
using System;
using System.Collections.Generic;

namespace ClubFutbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        private List<Jugador> jugadores;

        public Equipo(string nombre)
        {
            Nombre = nombre;
            jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
        }

        public void ListarJugadores()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }
}
