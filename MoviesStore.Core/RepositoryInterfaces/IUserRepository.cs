using MoviesStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStore.Core.RepositoryInterfaces
{
    public interface IUserRepository:IAsyncRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
