using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Attachment>().ToTable("Attachment");
        }*/
    }
}
