namespace Grupp7_GitOvning.Models
{
    public class LindasTestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string APointlessMethod()
        {
            return $"{Id}: {Name}\n{Description}";
        }
    }
}
