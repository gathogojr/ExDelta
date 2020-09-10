using ExDelta.Models;
using Microsoft.EntityFrameworkCore;

namespace ExDelta.Data
{
    public class ExDeltaDbContext : DbContext
    {
        public ExDeltaDbContext(DbContextOptions<ExDeltaDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Milestone> Milestones { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}
