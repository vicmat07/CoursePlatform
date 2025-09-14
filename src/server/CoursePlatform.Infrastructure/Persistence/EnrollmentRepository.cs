using CoursePlatform.Domain.Abstractions;
using CoursePlatform.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Infrastructure.Persistence
{
    internal class EnrollmentRepository(ApplicationDbContext context) : IEnrollmentRepository
    {
        public async Task<ICollection<Enrollment>> GetManyAsync(string userId)
        {
            return await context.Enrollments
                .Where(e => string.Equals(e.UserId, userId, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }
    }
}
