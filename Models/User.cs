using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTodoApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(255, ErrorMessage = "Name should not be more than 255")]
        public string Name { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(255, ErrorMessage = "Name should not be more than 255")]
        public string LastName { get; set; }

        [Required]
        [Column("password")]
        [StringLength(255, ErrorMessage = "Password should not be more than 255")]
        public string Password { get; set; }

        [Required]
        [Column("email")]
        [StringLength(255, ErrorMessage = "Email should not be more than 255")]
        public string Email { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}
