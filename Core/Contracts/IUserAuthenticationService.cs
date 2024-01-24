using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IUserAuthenticationService
    {
        Task<AuthUser> GetAuthenticatedUser(Claim claim);
    }
}
