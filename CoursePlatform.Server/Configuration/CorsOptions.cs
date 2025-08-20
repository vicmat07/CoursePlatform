namespace CoursePlatform.Server.Configuration
{
    public class CorsOptions
    {
        public const string CorsOption = "Cors";

        public string[] Origins { get; set; } = [];
    }
}
