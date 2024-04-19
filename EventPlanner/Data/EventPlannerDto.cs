﻿using EventPlanner.Models;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EventPlanner.Data
{
    public class GestionRendezVousContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Address> addresses { get; set; }

        public GestionRendezVousContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasOne(user => user.Address);
            modelBuilder.Entity<User>().HasMany<Event>(user => user.Events);
            modelBuilder.Entity<Event>().HasMany<User>(Event => Event.users);
            modelBuilder.Entity<Event>().HasOne(Event => Event.Address);
        }
    }
}
