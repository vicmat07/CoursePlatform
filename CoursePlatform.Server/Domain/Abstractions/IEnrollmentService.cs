using CoursePlatform.Server.Models;

namespace CoursePlatform.Server.Domain.Abstractions
{
    public interface IEnrollmentService
    {
        Task<ICollection<Enrollment>> GetAllByUserIdAsync(string userId);
    }
}
