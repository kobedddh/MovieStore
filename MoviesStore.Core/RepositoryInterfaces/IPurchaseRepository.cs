using MoviesStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStore.Core.RepositoryInterfaces
{
    public interface IPurchaseRepository:IAsyncRepository<Purchase>
    {
        //Task<Purchase> GetPurchaseByIds(int userId, int movieId);
        
    }
}
