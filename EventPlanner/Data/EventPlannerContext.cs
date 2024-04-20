using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EventPlanner.Data
{
    public class EventPlannerContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Address> addresses { get; set; }

        public EventPlannerContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(user => user.Events).WithMany(Event => Event.users);
            modelBuilder.Entity<User>().HasOne(user => user.Address);
            modelBuilder.Entity<Event>().HasOne(Event => Event.Address);
        }
    }
}
