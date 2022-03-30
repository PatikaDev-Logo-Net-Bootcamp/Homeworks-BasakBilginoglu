using Homeworkfour.DataAccess.EntityFramework.Configurations;
using Homeworkfour.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System;


namespace Homework4.DataAccess.EntityFramework


{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        }

    }


}



