using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Records> Records { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Records>().HasKey(m => m.RecordID);
            base.OnModelCreating(builder);
        }
    }
}
