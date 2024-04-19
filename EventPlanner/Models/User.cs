using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class User
    {
        [Required]
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }

        public virtual Address? Address { get; set; }
        public virtual Collection<Event>? Events { get; set; }
    }
}
