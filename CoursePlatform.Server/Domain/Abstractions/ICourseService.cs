using CoursePlatform.Server.Models;

namespace CoursePlatform.Server.Domain.Abstractions
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllAsync();
    }
}
