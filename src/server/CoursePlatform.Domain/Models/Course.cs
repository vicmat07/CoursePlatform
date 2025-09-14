namespace CoursePlatform.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public string? ThumbnailUrl { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<Lesson> Lessons { get; set; } = [];
        public ICollection<Enrollment> Enrollments { get; set; } = [];
    }
}
