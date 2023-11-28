using Core.Contracts;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(OnlineReservationContext context) : base(context)
        {
        }

        public async Task<User?> GetByTokenId(string tokenId)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.TokenId == tokenId);
        }
    }
}
