using System.ComponentModel.DataAnnotations;

namespace SunshineWax.Models.UserModels
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(12), MaxLength(20)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
