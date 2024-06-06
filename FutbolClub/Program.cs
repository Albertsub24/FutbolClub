using System;

namespace FutbolClub
{
    class Program
    {
        static Club club = new Club();

        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Barcelona");
            club.AgregarEquipo(equipo1);

            Jugador jugador1 = new Jugador("Lionel Messi", "Delantero", 10);
            club.AgregarJugador(jugador1);

            club.Menu();
        }
    }
}