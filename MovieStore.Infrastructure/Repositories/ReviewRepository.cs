using MoviesStore.Core.Entities;
using MoviesStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Infrastructure.Repositories
{
    public class ReviewRepository : EfRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MovieStoreDbContext dbContext):base(dbContext)
        {

        }
    }
}
