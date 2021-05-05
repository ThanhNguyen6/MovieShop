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

        public async Task<IActionResult> GetMoviesByGenre(int id)
        {
            var movies = await _movieService.GetMoviesByGenre(id);
            return View("~/Views/Home/Index.cshtml", movies);
        }

        public async Task<IActionResult> TopRatedMovie()
        {
            var movies = await _movieService.GetTopRatedMovies();
            return View(movies);
        }



        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetMovieById(id);
            return View("~/Views/Movies/Index.cshtml", movie);
        }

        public async Task<IActionResult> Reviews(int id)
        {
            var movie = await _movieService.GetMovieReviews(id);
            return View(movie);
        }

    }
}
