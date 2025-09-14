
using CoursePlatform.Domain.Models;

namespace CoursePlatform.Domain.Abstractions
{
    public interface ICourseRepository
    {
        Task<ICollection<Course>> GetManyAsync();
    }
}
