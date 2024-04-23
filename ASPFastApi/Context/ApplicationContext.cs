using Microsoft.EntityFrameworkCore;
using FastApi.Entity;
using System.Reflection.Emit; 

namespace FastApi.Context
{
    public class ApplicationContext : DbContext, IAppContext
    {        
         public DbSet<Article> Articles { get; set; }
 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options) { 
            //TestBuilder = modelBuilder;
        }
        public ApplicationContext() { }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer();

            //}
            //optionsBuilder.UseSqlServerO();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Article>().HasData
            DataSeed.generateData(modelBuilder);
            
        

            base.OnModelCreating(modelBuilder);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
