using CoursePlatform.Domain.Models;

namespace CoursePlatform.Application.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllAsync();

        Task<Course> CreateCourse();
    }
}
