using HomeRentingSystem.Infrastructure.Data.Configuration;
using HomeRentingSystem.Infrastructure.Data.Entities;
using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<House> Houses { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;
    }
}