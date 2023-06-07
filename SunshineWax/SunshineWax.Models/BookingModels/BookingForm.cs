using System.ComponentModel.DataAnnotations;

namespace SunshineWax.Models.BookingModels
{
    public class BookingForm
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string?  Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Expectations { get; set; }
    }
}
