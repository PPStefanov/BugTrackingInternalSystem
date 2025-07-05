using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BugTrackingInternalSystem.Data.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public ICollection<BugReport> ReportedBugs { get; set; }
    }
}
