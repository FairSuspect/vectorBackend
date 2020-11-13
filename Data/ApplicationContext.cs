using vectorBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace vectorBackend.Data {
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(new List<Role>{
                Role.Admin,
                Role.User
            });
        }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }

    

}