using CoursePlatform.Server.Models;

namespace CoursePlatform.Server.Services
{
    public interface IJwtService
    {
        string GenerateToken(ApplicationUser user, IList<string> roles);
    }
}
