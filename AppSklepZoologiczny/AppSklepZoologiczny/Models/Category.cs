using System.ComponentModel.DataAnnotations;

namespace AppSklepZoologiczny.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
