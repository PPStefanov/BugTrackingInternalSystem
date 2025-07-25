﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BugTrackingInternalSystem.Data.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Link to BugReport
        public int BugReportId { get; set; }
        public BugReport BugReport { get; set; }

        // Link to Author
        [Required]
        public string AuthorId { get; set; }
        public AppUser Author { get; set; }
    }
}
