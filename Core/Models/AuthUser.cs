namespace Core.Models
{
    public class AuthUser : EntityObject
    {
        public string TokenId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
