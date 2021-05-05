using ApplicationCore.Entities;
using ApplicationCore.Exceptions;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }
        //public Task<IEnumerable<Movie>> GetHighestRevenueMovies()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Review>> GetMovieReviews(int id)
        {
            var reviews = await _dbContext.Reviews.Where(r => r.MovieId == id).Include(r => r.User)
                .Select(r => new Review
                {
                    UserId = r.UserId,
                    Rating = r.Rating,
                    MovieId = r.MovieId,
                    ReviewText = r.ReviewText,
                    User = new User
                    {
                        Id = r.UserId,
                        FirstName = r.User.FirstName,
                        LastName = r.User.LastName
                    }
                }).Take(10).ToListAsync();

            return reviews;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            var movie = await _dbContext.Movies.Include(m => m.MovieCasts).ThenInclude(m => m.Cast)
                .Include(m => m.MovieGenres)
                .ThenInclude(m => m.Genre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                throw new NotFoundException("Movie Not found");
            }

            var movieRating = await _dbContext.Reviews.Where(r => r.MovieId == id).DefaultIfEmpty()
                .AverageAsync(r => r == null ? 0 : r.Rating);
            if (movieRating > 0) movie.Rating = movieRating;

            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            var movies = await _dbContext.Movies.Include(m => m.MovieGenres).ThenInclude(m=> m.Genre).ToListAsync();
            if (movies == null)
            {
                throw new NotFoundException("Movie Not found");
            }
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTop30HighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTopRatedMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Rating).Take(30).ToListAsync();
            return movies;
        }
    }
}
