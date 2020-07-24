using MoviesStore.Core.Entities;
using MoviesStore.Core.Models.Request;
using MoviesStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStore.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel requestModel);
        Task<UserLoginResponseModel> ValidateUser(string email, string password);
        Task<Purchase> PurchaseMovie(PurchaseRequestModel purchaseRequestModel);

        Task<bool> CheckPurchased(int userId, int MovieId);

        Task<IEnumerable<Movie>> PurchasedMovies(int id);

        Task<Favorite> LikeMovie(int userId, int MovieId);

        Task<bool> CheckFavorited(int userId, int MovieId);

        Task DeleteFavorite(int userId, int MovieId);

        Task<Review> Review(UserReviewRequestModel userReviewRequestModel);
        Task<bool> CheckReviewed(int userId, int movieId);
    }
}
