using MoviesStore.Core.Entities;
using MoviesStore.Core.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStore.Core.RepositoryInterfaces
{
    public interface IFavoriteRepository:IAsyncRepository<Favorite>
    {
        Task DeleteByIds(int userId, int MovieId);
    }
}
