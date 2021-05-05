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
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }
        public async Task<CastResponseModel> GetCastDetailsWithMovies(int id)
        {
            var cast = await _castRepository.GetByIdAsync(id);
            if (cast == null)
            {
                throw new NotFoundException("Cast", id);
            }

            //need to check this
            var response = new CastResponseModel
            {
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
                Movies = (IEnumerable<MovieResponseModel>)cast.MovieCasts,
            };
            return response;
        }
    }
}
