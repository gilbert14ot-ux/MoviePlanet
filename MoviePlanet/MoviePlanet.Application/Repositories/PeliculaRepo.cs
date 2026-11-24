using MoviePlanet.Application.Interfaces;
using MoviePlanet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlanet.Application.Repositories
{
    public class PeliculaRepo : IPeliculaRepository
    {
        private static readonly List<Pelicula> _peliculas = new List<Pelicula>();

        private static int sumadorId = 1;
        public Pelicula Crear(Pelicula pelicula)
        {
            pelicula.Id = sumadorId++;
            _peliculas.Add(pelicula);

            return pelicula;
        }

        public List<Pelicula> Mostrar()
        {
            return _peliculas;
        }
    }
}
