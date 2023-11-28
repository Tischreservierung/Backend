using Core.Contracts;
using Core.Models;
using System.Security.Claims;

namespace WebApi.Services
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserAuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> GetAuthenticatedUser(Claim claim)
        {
            string token_id = claim.Value;
            User? user = await _unitOfWork.Users.GetByTokenId(token_id);

            if (user == null)
            {
                user = new User()
                {
                    TokenId = token_id
                };

                _unitOfWork.Users.Insert(user);
                await _unitOfWork.SaveChangesAsync();
            }

            return user;
        }
    }
}
