using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        public int id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}