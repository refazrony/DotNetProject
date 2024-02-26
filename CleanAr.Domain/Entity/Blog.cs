using System.ComponentModel;

namespace CleanAr.Domain.Entity
{
    public class Blog
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}