using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Genre(int id)
        {
            var movies = await _movieService.GetMoviesByGenre(id);
            return View(movies);
        }

        public async Task<IActionResult> TopRatedMovie()
        {
            var movies = await _movieService.GetTopRatedMovies();
            return View(movies);
        }

    }
}
