using MoviePlanet.Application.Interfaces;
using MoviePlanet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlanet.Application.Services
{
    public class PeliculaService
    {
        private readonly IPeliculaRepository peliRepo;

        public PeliculaService(IPeliculaRepository peliRepository)
        {
            peliRepo = peliRepository;
        }

        public Pelicula CrearPelicula(Pelicula pelicula)
        {
            if (string.IsNullOrWhiteSpace(pelicula.Titulo))
            {
                throw new ArgumentException("El titulo es necesario para registrar");
            }

            return peliRepo.Crear(pelicula);
        }

        public List<Pelicula> MostrarPeliculas()
        {
            return peliRepo.Mostrar();
        }
    }
}
