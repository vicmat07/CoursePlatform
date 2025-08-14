using CoursePlatform.Server.Domain.Abstractions;
using CoursePlatform.Server.Models;
using CoursePlatform.Server.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Server.Services
{
    public class CourseService(ApplicationDbContext context) : ICourseService
    {
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
