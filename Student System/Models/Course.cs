namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<HomeWorkSubmissions> HomeWorkSubmissions { get; set; } = new List<HomeWorkSubmissions>();

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    }
}
