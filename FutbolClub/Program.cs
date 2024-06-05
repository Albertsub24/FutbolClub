using System;

namespace FutbolClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            while (true)
            {
                Console.WriteLine("1. Crear equipo");
                Console.WriteLine("2. Listar equipos");
                Console.WriteLine("3. Crear jugador");
                Console.WriteLine("4. Asignar jugador a equipo");
                Console.WriteLine("5. Listar jugadores de un equipo");
                Console.WriteLine("6. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre del equipo: ");
                        string nombreEquipo = Console.ReadLine();
                        club.AgregarEquipo(new Equipo(nombreEquipo));
                        break;
                    case "2":
                        club.ListarEquipos();
                        break;
                    case "3":
                        Console.Write("Nombre del jugador: ");
                        string nombreJugador = Console.ReadLine();
                        Console.Write("Posición del jugador: ");
                        string posicionJugador = Console.ReadLine();
                        Console.Write("Número del jugador: ");
                        int numeroJugador = int.Parse(Console.ReadLine());
                        club.AgregarJugador(new Jugador(nombreJugador, posicionJugador, numeroJugador));
                        break;
                    case "4":
                        Console.Write("Nombre del equipo: ");
                        string equipoParaAsignar = Console.ReadLine();
                        Console.Write("Número del jugador: ");
                        int numeroParaAsignar = int.Parse(Console.ReadLine());
                        club.AsignarJugadorAEquipo(numeroParaAsignar, equipoParaAsignar);
                        break;
                    case "5":
                        Console.Write("Nombre del equipo: ");
                        string equipoParaListar = Console.ReadLine();
                        club.ListarJugadoresDeEquipo(equipoParaListar);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}