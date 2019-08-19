using Microsoft.EntityFrameworkCore;
using Web_Api.DTO.Data.Model;
namespace Web_Api.DTO.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
        }
        public DbSet<User> users {get; set;}
    }
}