using System;
using System.Collections.Generic;
using System.Text;
using EduConcept.BL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduConcept.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>(entity =>
            {
                entity
                .HasMany(e => e.Children)
                .WithOne(e => e.Parent)
                .HasForeignKey(e => e.ParentId);
            });
            base.OnModelCreating(builder);  
        }
    }
}
