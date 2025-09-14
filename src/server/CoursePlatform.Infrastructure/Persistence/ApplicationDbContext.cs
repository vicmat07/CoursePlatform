using CoursePlatform.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Infrastructure.Persistence
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        
        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.Entity<Enrollment>()
             .HasIndex(e => new { e.UserId, e.CourseId })
             .IsUnique();
        }
    }
}
