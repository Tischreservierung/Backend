using Core.Models;

namespace Core.Contracts
{
    public interface IUserRepository : IGenericRepository<AuthUser>
    {
        void AddEmployee(Restaurant restaurant, AuthUser user);
        Task<AuthUser?> GetByTokenId(string tokenId);
    }
}
