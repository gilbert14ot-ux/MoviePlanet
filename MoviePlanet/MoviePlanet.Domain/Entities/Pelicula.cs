using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlanet.Domain.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set;  }
        public string? Genero { get; set; }
        public int FechaDeSalida { get; set; }
        public int Duracion { get; set; }
        public double Rating { get; set;  }

    }
}
