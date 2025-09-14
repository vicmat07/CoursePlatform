using CoursePlatform.Domain.Abstractions;
using CoursePlatform.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Infrastructure.Persistence
{
    internal class CourseRepository(ApplicationDbContext context) : ICourseRepository
    {
        public async Task<ICollection<Course>> GetManyAsync()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
