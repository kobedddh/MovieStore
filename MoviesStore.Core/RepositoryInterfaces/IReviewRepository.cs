using MoviesStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStore.Core.RepositoryInterfaces
{
    public interface IReviewRepository:IAsyncRepository<Review>
    {
    }
}
