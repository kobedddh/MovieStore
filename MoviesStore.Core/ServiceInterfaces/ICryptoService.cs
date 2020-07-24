using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesStore.Core.ServiceInterfaces
{
    public interface ICryptoService
    {
        string GenerateSalt();
        string HashPassword(string password,string salt);
    }
}
