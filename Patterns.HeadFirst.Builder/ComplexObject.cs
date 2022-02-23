namespace Patterns.HeadFirst.Builder
{
    public class ComplexObject
    {
        public string Name { get; }
        public DateTime? Expiration { get; set; }
        public string? Creator { get; set; }
        public Dictionary<string, string>? Details { get; set; }

        public ComplexObject(string name)
        {
            Name = name;
        }
        
    }
}