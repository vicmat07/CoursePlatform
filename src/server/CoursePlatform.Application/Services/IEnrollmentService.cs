using CoursePlatform.Domain.Models;

namespace CoursePlatform.Application.Services
{
    public interface IEnrollmentService
    {
        Task<ICollection<Enrollment>> GetAllByUserIdAsync(string userId);

        Task<Enrollment> EnrollAsync(int courseId, string userId);
    }
}
