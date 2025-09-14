namespace CoursePlatform.Domain.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string? VideoUrl { get; set; }
        public string? ContentMarkdown { get; set; }
        public int Order { get; set; }
    }
}
