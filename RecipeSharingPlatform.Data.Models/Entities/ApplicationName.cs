using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTrackingInternalSystem.Data.Models.Entities
{
    public class ApplicationName
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public ICollection<BugReport> BugReports { get; set; } = new List<BugReport>();
    }
}
