using MoviesStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStore.Core.RepositoryInterfaces
{
    public interface IGenreRepository:IAsyncRepository<Genre>
    {
        Task<IEnumerable<Genre>> GetAllGenres();
        Task<IEnumerable<Movie>> GetMoviesByGenre(int id);
        Task<IEnumerable<Genre>> GetGenresByMovie(int id);
    }
}
