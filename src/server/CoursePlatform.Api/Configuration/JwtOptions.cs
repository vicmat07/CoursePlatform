namespace CoursePlatform.Api.Configuration
{
    public class JwtOptions
    {
        public const string Jwt = "Jwt";

        public string Key { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }
}
