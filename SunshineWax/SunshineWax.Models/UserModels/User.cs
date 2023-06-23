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
        [DataType(DataType.Password)]
        [MinLength(12), MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
