using System.ComponentModel.DataAnnotations;

namespace SunshineWax.Models.BookingModels
{
    public class Days
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Day { get; set; }
    }
}
