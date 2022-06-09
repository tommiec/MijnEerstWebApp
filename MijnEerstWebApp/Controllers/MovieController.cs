using Microsoft.AspNetCore.Mvc;
using MijnEerstWebApp.Database;
using MijnEerstWebApp.Models;

namespace MijnEerstWebApp.Controllers
{
    public class MovieController : Controller
    {
        private IMovieDatabase movieDatabase;

        public MovieController(IMovieDatabase movieDatabase)
        {
            this.movieDatabase = movieDatabase;
        }

        public IActionResult Index()
        {
            var vm = movieDatabase.GetMovies().Select(x => new MovieListViewModel
            {
                MovieId = x.MovieId,
                Title = x.Title,
                Description = x.Description
            });
            return View(vm);
        }


    }
}
