using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EventPlanner.Models
{
    public class Event
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Address? Address { get; set; }
        public virtual ICollection<User>? users { get; set; }
    }
}
