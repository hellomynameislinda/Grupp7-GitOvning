namespace Grupp7_GitOvning.Models
{
    public class LindasTestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string APointlessMethod()
        {
            Random testRandom = new Random();
            var myNum = testRandom.Next(12,15);
            
            return $"{Id}: {Name}\n{Description}\n{myNum}";
        }
    }
}
