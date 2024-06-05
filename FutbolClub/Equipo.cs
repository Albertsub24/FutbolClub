
using System;
using System.Collections.Generic;

namespace FutbolClub
{
    public class Equipo
    {
        //public int Id { get; set; }
        public string Nombre { get; set; }
        List<Jugador> Jugadores;

        //public Equipo(int id, string nombre)
        public Equipo(string nombre)
        {
            //Id = id;
            Nombre = nombre;
            List<Jugador> Jugadores = new List<Jugador>();
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
