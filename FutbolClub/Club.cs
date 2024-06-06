using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolClub
{
    class Club
    {
        private List<Jugador> jugadores = new List<Jugador>();
        private List<Equipo> equipos = new List<Equipo>();

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
            Jugador jugador = jugadores.FirstOrDefault(j => j.NumeroCamiseta == numeroJugador);
            Equipo equipo = equipos.FirstOrDefault(e => e.Nombre == nombreEquipo);

            if (jugador != null && equipo != null)
            {
                equipo.AgregarJugador(jugador);
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
                equipo.ListarJugadores();
            }
            else
            {
                Console.WriteLine("Equipo no encontrado");
            }
        }

        public void Menu()
        {
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
                        AgregarEquipo(new Equipo(nombreEquipo));
                        break;
                    case "2":
                        ListarEquipos();
                        break;
                    case "3":
                        Console.Write("Nombre del jugador: ");
                        string nombreJugador = Console.ReadLine();
                        Console.Write("Posición del jugador: ");
                        string posicionJugador = Console.ReadLine();
                        Console.Write("Número del jugador: ");
                        int numeroJugador = int.Parse(Console.ReadLine());
                        AgregarJugador(new Jugador(nombreJugador, posicionJugador, numeroJugador));
                        break;
                    case "4":
                        Console.Write("Nombre del equipo: ");
                        string equipoParaAsignar = Console.ReadLine();
                        Console.Write("Número del jugador: ");
                        int numeroParaAsignar = int.Parse(Console.ReadLine());
                        AsignarJugadorAEquipo(numeroParaAsignar, equipoParaAsignar);
                        break;
                    case "5":
                        Console.Write("Nombre del equipo: ");
                        string equipoParaListar = Console.ReadLine();
                        ListarJugadoresDeEquipo(equipoParaListar);
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