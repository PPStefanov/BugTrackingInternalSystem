using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTrackingInternalSystem.Data.Models.Entities
{
    public enum BugPriority
    {
        Low,
        Medium,
        High,
        Critical
    }
}
