using Core.Entitites.UserEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //                .AddJsonFile("appsettings.json")
        //                .Build();
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        //}
    }
}
