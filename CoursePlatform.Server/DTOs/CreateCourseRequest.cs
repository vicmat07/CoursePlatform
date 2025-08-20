namespace CoursePlatform.Server.DTOs
{
    public class CreateCourseRequest
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ThumbnailUrl { get; set; }
    }
}
