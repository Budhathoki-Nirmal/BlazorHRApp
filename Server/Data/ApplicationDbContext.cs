using BlazorHRApp.Server.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorHRApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(x => x.Mobile).IsUnique();

            modelBuilder.Entity<Department>().HasIndex(x => x.DName).IsUnique();

            modelBuilder.Entity<Position>().HasIndex(x => x.PName).IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}