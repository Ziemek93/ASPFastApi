using ASPFastApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastApi.Context
{
    public interface IAppContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public ApplicationContext CreateDbContext();
        Task<int> SaveChangesAsync();

    }
}
