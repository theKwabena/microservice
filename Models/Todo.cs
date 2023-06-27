using System.ComponentModel.DataAnnotations;

namespace microservice.Models
{
    public class Todo
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string title { get; set; }
        public DateTime dateAdded { get; set; } = DateTime.Today;
        public bool iscompleted { get; set; } = false;
    }
}
