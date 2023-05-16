using System.ComponentModel.DataAnnotations;

namespace ItemManagementSystem.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; } = null;
    }
}
