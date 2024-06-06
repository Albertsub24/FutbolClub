using System;

namespace FutbolClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            Equipo equipo1 = new Equipo("Barcelona");
            club.AgregarEquipo(equipo1);

            Jugador jugador1 = new Jugador("Lionel Messi", "Delantero", 10);
            club.AgregarJugador(jugador1);

            club.Menu();
        }
    }
}