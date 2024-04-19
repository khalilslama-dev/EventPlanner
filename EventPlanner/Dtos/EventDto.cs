using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class EventDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<User>? users { get; set; }
    }
}
