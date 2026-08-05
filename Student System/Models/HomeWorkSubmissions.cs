namespace P01_StudentSystem.Models
{
    enum ContentType
    {
        Application = 1,
        Pdf = 2,
        Zip = 3
    }
    internal class HomeWorkSubmissions
    {
        public int HomeWorkId { get; set; }

        public string Content { get; set; } = string.Empty;

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; } = new();
        public Student Student { get; set; } = new();

    }
}
