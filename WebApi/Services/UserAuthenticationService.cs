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

        public async Task<AuthUser> GetAuthenticatedUser(Claim claim)
        {
            string token_id = claim.Value;
            AuthUser? user = await _unitOfWork.Users.GetByTokenId(token_id);

            if (user == null)
            {
                user = new AuthUser()
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
