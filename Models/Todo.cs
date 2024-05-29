using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTodoApp.Models
{
    [Table("todo")]
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("is_completed")]
        public bool IsCompleted { get; set; }
    }
}
