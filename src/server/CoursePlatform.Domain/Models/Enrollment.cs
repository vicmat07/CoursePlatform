﻿namespace CoursePlatform.Domain.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public string UserId { get; set; } = default!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
    }
}
