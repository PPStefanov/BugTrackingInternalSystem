using BugTrackingInternalSystem.Data.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingInternalSystem.Data
{
    public class BugTrackingInternalSystemDbContext : IdentityDbContext
    {
        public BugTrackingInternalSystemDbContext(DbContextOptions<BugTrackingInternalSystemDbContext> options)
            : base(options)
        {
        }


        public DbSet<BugReport> BugReports { get; set; }
        public DbSet<ApplicationName> ApplicationName { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Optional: Fluent API configs (if needed)
            builder.Entity<BugReport>()
                .HasOne(b => b.Reporter)
                .WithMany(u => u.ReportedBugs)
                .HasForeignKey(b => b.ReporterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Comment>()
                .HasOne(c => c.Author)
                .WithMany()
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
