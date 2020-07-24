using MoviesStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MoviesStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MovieStore.Infrastructure.Repositories
{
    public class PurchaseRepository : EfRepository<Purchase>, IPurchaseRepository
    {

        public PurchaseRepository(MovieStoreDbContext dbContext):base(dbContext)
        {

        }


        //{
        //    return await _dbContext.Purchases.Where(p => p.UserId == userId && p.MovieId == movieId).FirstOrDefaultAsync();
        //}
    }
}
