﻿using MijnEerstWebApp.Domain;

namespace MijnEerstWebApp.Database
{
    public interface IMovieDatabase
    {
        Movie Insert(Movie movie);
        Movie GetMovie(int id);
        IEnumerable<Movie> GetMovies();
        void Update(int id, Movie movie);
        void Delete(int id);

    }
}
