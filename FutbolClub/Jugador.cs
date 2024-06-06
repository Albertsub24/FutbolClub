using System;
using System.Collections.Generic;
using System.Linq;

namespace FutbolClub
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int NumeroCamiseta { get; set; }
        public string Posicion { get; set; }

        public Jugador(string nombre, string posicion, int numeroCamiseta)
        {
            Nombre = nombre;
            Posicion = posicion;
            NumeroCamiseta = numeroCamiseta;
        }

        public override string ToString()
        {
            return $"{NumeroCamiseta} - {Nombre} ({Posicion})";
        }
    }
}