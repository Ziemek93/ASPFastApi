using Microsoft.EntityFrameworkCore;
using FastApi.Entity;

namespace FastApi.Context
{
    public interface IAppContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        Task<int> SaveChangesAsync();

    }
}
