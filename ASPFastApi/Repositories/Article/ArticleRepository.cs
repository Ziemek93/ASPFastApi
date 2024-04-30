using ASPFastApi.Features.Public.GetArticles;
using FastApi.Context;
using Microsoft.EntityFrameworkCore;

namespace ASPFastApi.Repositories.Article
{
    public class ArticleRepository
    {
        private readonly ApplicationContext _context;

        public ArticleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Response>> GetArticles(ArticleMapper mapper)
        {
            var result = await _context.Articles
                .Include(a => a.Comments)
                .Include(a => a.Tags)
                .ToListAsync(); //GetArticles(context);
            var entity = result.Select(a =>
                mapper.FromEntity(a))
                .OrderBy(a => a.ArticleName)
                .ToList();

            return entity;
        }
    }
}
