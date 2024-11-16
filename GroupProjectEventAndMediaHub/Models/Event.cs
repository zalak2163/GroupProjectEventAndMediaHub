using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProjectEventAndMediaHub.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;

        public required virtual Location Location { get; set; }
        public int LocationId { get; set; }

        public required virtual User Users { get; set; }
        public int OrganizerId { get; set; }
    }
}
