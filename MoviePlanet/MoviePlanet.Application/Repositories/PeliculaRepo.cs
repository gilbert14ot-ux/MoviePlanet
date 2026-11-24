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

        public Pelicula? GetById(int id)
        {
            return _peliculas.FirstOrDefault(pelicula => pelicula.Id == id);
        }

        public Pelicula? Actualizar(Pelicula pelicula)
        {
            var existeLaPeli = _peliculas.FirstOrDefault(p => p.Id == pelicula.Id);

            if (existeLaPeli == null)
            {
                return null;
            }

            existeLaPeli.Titulo = pelicula.Titulo;
            existeLaPeli.Descripcion = pelicula.Descripcion;
            existeLaPeli.Genero = pelicula.Genero;
            existeLaPeli.Duracion = pelicula.Duracion;
            existeLaPeli.FechaDeSalida = pelicula.FechaDeSalida;
            existeLaPeli.Rating = pelicula.Rating;

            return existeLaPeli;
        }
    }
}
