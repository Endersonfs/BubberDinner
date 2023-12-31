namespace BuberDinner.Infrastructure.Authentication
{
    public class JwSetting
    {
        public const string  SecctionName = "JwtSettings";
        public string Secret { get; init; } = null!;
        public int ExpiryMinutes { get; init; } 
        public string Issuer { get; init; } = null!;
        public string Audience { get; init; } = null!;
    }
}