using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFutbol
{
    class Club
    {
        private List<Equipo> equipos;

        public Club()
        {
            equipos = new List<Equipo>();
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
    }
}
