namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public ICollection<HomeWorkSubmissions> HomeWorkSubmissions { get; set; } = new List<HomeWorkSubmissions>();

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
