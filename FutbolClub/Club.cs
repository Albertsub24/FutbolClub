using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolClub
{
    class Club
    {
        private List<Equipo> equipos;
        private List<Jugador> jugadores;

        public Club()
        {
            equipos = new List<Equipo>();
            jugadores = new List<Jugador>();
        }

        public void AgregarEquipo(Equipo equipo)
        {
            equipos.Add(equipo);
        }

        public void ListarEquipos()
        {
            foreach (var equipo in equipos)
            {
                Console.WriteLine(equipo.Nombre);
            }
        }

        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
        }

        public void AsignarJugadorAEquipo(int numeroJugador, string nombreEquipo)
        {
            Jugador jugador = jugadores.Find(j => j.NumeroCamiseta == numeroJugador);
            Equipo equipo = equipos.Find(e => e.Nombre == nombreEquipo);

            if (jugador != null && equipo != null)
            {
                equipo.AddJugador(jugador);
                Console.WriteLine($"Jugador {jugador.Nombre} asignado al equipo {equipo.Nombre}");
            }
            else
            {
                Console.WriteLine("Jugador o equipo no encontrado");
            }
        }

        public void ListarJugadoresDeEquipo(string nombreEquipo)
        {
            Equipo equipo = equipos.Find(e => e.Nombre == nombreEquipo);

            if (equipo != null)
            {
                equipo.ViewJugadores();
            }
            else
            {
                Console.WriteLine("Equipo no encontrado");
            }
        }
    }
}