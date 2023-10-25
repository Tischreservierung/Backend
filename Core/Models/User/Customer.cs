using Microsoft.EntityFrameworkCore;

namespace Core.Models.User
{
    [Index(nameof(CustomerNumber), IsUnique = true)]
    public class Customer : Person
    {
        public string CustomerNumber { get; set; } = string.Empty;

    }
}
