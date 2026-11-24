using MoviePlanet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlanet.Application.Interfaces
{
    public interface IPeliculaRepository
    {
        Pelicula Crear(Pelicula pelicula);
        List<Pelicula> Mostrar();
        Pelicula? GetById(int id);
        Pelicula? Actualizar(Pelicula pelicula);
        bool Eliminar(int id);
    }
}
