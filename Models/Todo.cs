using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTodoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        [StringLength(100, ErrorMessage = "Should not be more than 100")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("is_completed")]
        public bool IsCompleted { get; set; }

        
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
