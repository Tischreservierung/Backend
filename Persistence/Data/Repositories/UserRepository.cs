using Core.Contracts;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Repositories
{
    public class UserRepository : GenericRepository<AuthUser>, IUserRepository
    {
        public UserRepository(OnlineReservationContext context) : base(context)
        {
        }

        public async Task<AuthUser?> GetByTokenId(string tokenId)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.TokenId == tokenId);
        }
    }
}
