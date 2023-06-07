using System.ComponentModel.DataAnnotations;

namespace SunshineWax.Models.BookingModels
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? EstimatedTime { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
