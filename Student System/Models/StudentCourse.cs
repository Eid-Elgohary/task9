namespace P01_StudentSystem.Models
{
    internal class StudentCourse
    {

        public int StudentId { get; set; }
        public Student Student { get; set; } = new();

        public int CourseId { get; set; }
        public Course Course { get; set; } = new();
    }
}
