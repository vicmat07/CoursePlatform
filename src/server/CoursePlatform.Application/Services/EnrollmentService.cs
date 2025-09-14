using CoursePlatform.Domain.Models;

namespace CoursePlatform.Application.Services
{
    internal class EnrollmentService : IEnrollmentService
    {
        public Task<Enrollment> EnrollAsync(int courseId, string userId)
        {
            //var existingCourse = await context.Courses
            //    .FirstOrDefaultAsync(c => c.Id == courseId);

            //if (existingCourse is null)
            //{
            //    //create custom exception
            //    throw new ArgumentException();
            //}

            //var existingEnrollment = await context.Enrollments
            //    .Include(e => e.Course)
            //    .Include(e => e.User)
            //    .FirstOrDefaultAsync(e => e.CourseId == courseId && e.UserId == userId);

            //if (existingEnrollment is not null)
            //{
            //    //create custom exception
            //    throw new ArgumentException();
            //}

            //var enrollment = new Enrollment
            //{
            //    CourseId = existingCourse.Id,
            //    UserId = userId,
            //    EnrolledAt = DateTime.UtcNow
            //};

            //await context.Enrollments.AddAsync(enrollment);
            //await context.SaveChangesAsync();

            //return enrollment;
            throw new NotImplementedException();
        }

        public Task<ICollection<Enrollment>> GetAllByUserIdAsync(string userId)
        {
            //return await context.Enrollments.Where(e => e.UserId == userId).ToListAsync();
            throw new NotImplementedException();
        }
    }
}
