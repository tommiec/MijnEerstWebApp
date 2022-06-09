using MijnEerstWebApp.Domain;

namespace MijnEerstWebApp.Database
{
    public class MovieDatabase : IMovieDatabase
    {
        private int counter = 0;
        private List<Movie> movies;

        public MovieDatabase()
        {
            movies = new List<Movie>();

            Insert(new Movie
            {
                Title = "De Smurfen",
                Description = "Blauwe gnomes",
                Genre = "Kids",
                Rating = 8
            });

            Insert(new Movie
            {
                Title = "Frozen",
                Description = "Met Elza",
                Genre = "Kids",
                Rating = 6
            });

            Insert(new Movie
            {
                Title = "Encanto",
                Description = "Met levend huis gnomes",
                Genre = "Kids",
                Rating = 9
            });


        }

        public Movie Insert(Movie movie)
        {
            movie.MovieId = counter++;
            movies.Add(movie);
            return movie;
        }

        public void Update(int id, Movie updatedMovie)
        {
            var movie = movies.FirstOrDefault(x => x.MovieId == id);
            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Description = updatedMovie.Description;
                movie.Genre = updatedMovie.Genre;
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        public void Delete(int id)
        {
            var movie = movies.FirstOrDefault(x => x.MovieId == id);
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }

        public Movie GetMovie(int id)
        {
            return movies.FirstOrDefault(x => x.MovieId == id);
        }
    }
}
