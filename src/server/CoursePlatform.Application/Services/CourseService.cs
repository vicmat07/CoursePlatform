using CoursePlatform.Domain.Abstractions;
using CoursePlatform.Domain.Models;

namespace CoursePlatform.Application.Services
{
    internal class CourseService(ICourseRepository courseRepository) : ICourseService
    {
        public Task<Course> CreateCourse()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await courseRepository.GetManyAsync();
        }
    }
}
