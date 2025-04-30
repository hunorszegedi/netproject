namespace projectSapviz.Models
{
    public class StudentEntry
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string School { get; set; } = "";
        public string Specialization { get; set; } = "";
        public Dictionary<int, Dictionary<int, Dictionary<string, string>>> Grades { get; set; } = new();
    }
}
