using ApplicationCore.Exceptions;
using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<MovieResponseModel>> GetTop30RevenueMovie()
        {
            var movies = await _movieRepository.GetTop30HighestRevenueMovies();

            var topMovies = new List<MovieResponseModel>();
            foreach (var movie in movies)
            {
                topMovies.Add(new MovieResponseModel
                {
                    Id = movie.Id,
                    Budget = (decimal)movie.Budget,
                    Title = movie.Title
                });
            }

            return topMovies;
        }

        //public async Task<List<MovieResponseModel>> GetHighestRevenueMovies()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<ReviewResponseModel>> GetMovieReviews(int id)
        {
            var reviews = await _movieRepository.GetMovieReviews(id);

            var response = new List<ReviewResponseModel>();
            foreach (var review in reviews)
            {
                response.Add(new ReviewResponseModel
                {
                    Name = review.User.FirstName,
                    Rating = (decimal)review.Rating,
                    ReviewText = review.ReviewText
                });
            }

            return response;
        }

        public async Task<List<MovieResponseModel>> GetMoviesByGenre(int genreId)
        {
            var movies = await _movieRepository.GetMoviesByGenre(genreId);

            var topMovies = new List<MovieResponseModel>();
            foreach (var movie in movies)
            {
                topMovies.Add(new MovieResponseModel
                {
                    Id = movie.Id,
                    Budget = (decimal)movie.Budget,
                    Title = movie.Title
                });
            }

            return topMovies;
        }

        public async Task<List<MovieResponseModel>> GetTopRatedMovies()
        {
            var movies = await _movieRepository.GetTopRatedMovies();

            var topMovies = new List<MovieResponseModel>();
            foreach (var movie in movies)
            {
                topMovies.Add(new MovieResponseModel
                {
                    Id = movie.Id,
                    Budget = (decimal)movie.Budget,
                    Title = movie.Title
                });
            }

            return topMovies;
        }

        public async Task<MovieDetailsResponseModel> GetMovieById(int id)
        {
            var movie = await _movieRepository.GetMovieById(id);
            if (movie == null) throw new NotFoundException("Movie", id);
            return new MovieDetailsResponseModel
            {
                Id = movie.Id,
                Budget = (decimal)movie.Budget,
                Title = movie.Title
                //how to casts and reviews?
            };
        }
    }
}
