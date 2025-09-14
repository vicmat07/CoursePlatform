
using CoursePlatform.Domain.Models;

namespace CoursePlatform.Domain.Abstractions
{
    public interface IEnrollmentRepository
    {
        Task<ICollection<Enrollment>> GetManyAsync(string userId);
    }
}
