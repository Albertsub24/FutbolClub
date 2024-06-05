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
                Console.WriteLine("1. Agregar equipo");
                Console.WriteLine("2. Listar equipos");
                Console.WriteLine("3. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Nombre del equipo:");
                        string nombreEquipo = Console.ReadLine();
                        Equipo equipo = new Equipo(nombreEquipo);
                        club.AgregarEquipo(equipo);
                        break;
                    case "2":
                        club.ListarEquipos();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}
