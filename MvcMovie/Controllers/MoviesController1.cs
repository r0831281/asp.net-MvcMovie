using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var movies = _context.Movies.OrderBy(m => m.Title);

            return View(movies.ToList());
        }

    }
}