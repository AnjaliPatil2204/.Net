using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public required string Email { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public required string Password { get; set; }
    }
}
