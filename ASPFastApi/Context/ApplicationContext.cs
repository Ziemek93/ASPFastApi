using ASPFastApi.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FastApi.Context
{
    public class ApplicationContext : IdentityDbContext, IAppContext
    {
        private readonly DbContextOptions<ApplicationContext> _options;
        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //TestBuilder = modelBuilder;
            _options = options;
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
            var options = optionsBuilder;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasIndex(x => x.Title)
                .IsUnique();

            //modelBuilder.Entity<Article>().HasData
            DataSeed.generateData(modelBuilder);



            base.OnModelCreating(modelBuilder);

            #region User
            //modelBuilder.Entity<User>().HasMany<Article>(x => x.);
            #endregion

            #region Article
            //modelBuilder.Entity<Article>().HasOne<User>(x => x.User).WithMany(x => x.Articles).HasForeignKey(x => x.UserId);
            #endregion

            #region Comments
            //modelBuilder.Entity<Comment>().HasOne<User>(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId);

            #endregion
        }
        public ApplicationContext CreateDbContext()
        {
            return new ApplicationContext(_options);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
