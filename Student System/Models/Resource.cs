namespace P01_StudentSystem.Models
{
    public enum ResourceType
    {
        Video = 1,
        Presentation = 2,
        Document = 3,
        Other = 4
    }

    internal class Resource
    {
        public int ResourceId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; } = new();


    }
}
