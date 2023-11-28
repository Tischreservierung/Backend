using Core.Models;

namespace Core.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByTokenId(string tokenId);
    }
}
