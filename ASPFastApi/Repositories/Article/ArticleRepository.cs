using FastApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Add = ASPFastApi.Features.Public.AddArticle;
using Get = ASPFastApi.Features.Public.GetArticles;
using ASPFastApi.Models.Entities;

namespace ASPFastApi.Repositories.Articles;

public class ArticleRepository : IArticleRepository
{
    private readonly ApplicationContext _context;

    public ArticleRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Article>> GetArticles(CancellationToken token)
    {
        using var context = _context;

        return await context.Articles
            .Include(a => a.Comments)
            .Include(a => a.Tags)
            .ToListAsync(token); //GetArticles(context);
    }

    public async Task<bool> CategoryExist(Article request, CancellationToken token = default)
    {
        using var context = _context;
        var categoryExists = await context.Categories.Where(c => c.CategoryId == request.CategoryId).AnyAsync();
        return categoryExists;
    }
    public async Task<bool> ArticleExist(Article request, CancellationToken token = default)
    {
        using var context = _context;
        var categoryExists = context.Articles.Where(c => c.ArticleId == request.ArticleId).AnyAsync();
        return await categoryExists;
    }

    public async Task<int> AddArticle (Article request, CancellationToken token = default)
    {
        using var context = _context;
        var response = context.Articles.Add(request);
        var result = await context.SaveChangesAsync(token);

        return result;
    }
    public async Task<Article?> GetArticle(int id, CancellationToken token = default)
    {
        using var context = _context;
        var article = await context.Articles.Where(x=>x.ArticleId == id).FirstOrDefaultAsync();
        return article;

    }
    public async Task<bool> EditArticle(Article request, CancellationToken token = default)
    {
        using var context = _context;
        var entity = await context.Articles
            .Where(x => x.ArticleId == request.ArticleId)
            .FirstOrDefaultAsync();
        if(entity == null)
        {
            return false;
        }
        entity.ArticleName = request.ArticleName;
        entity.ArticleDescription = request.ArticleDescription;
        entity.Tags = request.Tags; // entity.Tags.Union(request.Tags).ToList();

        var result = await context.SaveChangesAsync(token);

        return result != 0;



    }



}
