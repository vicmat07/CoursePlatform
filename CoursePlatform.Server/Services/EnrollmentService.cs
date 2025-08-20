using CoursePlatform.Server.Domain.Abstractions;
using CoursePlatform.Server.Models;
using CoursePlatform.Server.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Server.Services
{
    public class EnrollmentService(
        ApplicationDbContext context) : IEnrollmentService
    {
        public async Task<ICollection<Enrollment>> GetAllByUserIdAsync(string userId)
        {
           return await context.Enrollments.Where(e => e.UserId == userId).ToListAsync();
        }
    }
}
