using Core.Models;

namespace Core.Contracts
{
    public interface IUserRepository : IGenericRepository<AuthUser>
    {
        Task<AuthUser?> GetByTokenId(string tokenId);
    }
}
