using CoursePlatform.Server.Domain.Abstractions;
using CoursePlatform.Server.Models;
using CoursePlatform.Server.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Server.Services
{
    internal class CourseService(ApplicationDbContext context) : ICourseService
    {
        public Task<Course> CreateCourse()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
