using ApplicationCore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieResponseModel>> GetTop30RevenueMovie();
        Task<List<MovieResponseModel>> GetTopRatedMovies();
        Task<List<MovieResponseModel>> GetMoviesByGenre(int genreId);
        //Task<List<MovieResponseModel>> GetHighestRevenueMovies();
        Task<List<ReviewResponseModel>> GetMovieReviews(int id);

        Task<MovieDetailsResponseModel> GetMovieById(int id);

    }
}
