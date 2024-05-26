using FastApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Add = ASPFastApi.Features.Public.AddArticle;
using Get = ASPFastApi.Features.Public.GetArticles;
using ASPFastApi.Models.Entities;
using System.ComponentModel.DataAnnotations;
using Edit = ASPFastApi.Features.Public.EditArticle;
using ASPFastApi.Migrations;

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
        var article = await context.Articles
            .Where(x=>x.ArticleId == id)
            .Include(a => a.Comments)
            .Include(a => a.Tags)
            .FirstOrDefaultAsync();
        return article;

    }

    private async Task<IEnumerable<Tag>> InsertTags(IEnumerable<string> tagsTitles, CancellationToken token = default)
    {
        using var context = _context;
        //Tag tag1 = new Tag
        //{
        //    Title = "sse bWsts"
        //};
        //Tag tag2 = new Tag
        //{
        //    Title = "TST2"
        //};

        //IEnumerable<Tag> tagsTST = new List<Tag>()
        //{
        //    tag1,
        //    tag2
        //};
        //var t = context.Tags.Add(tag1);

        IEnumerable<Tag> tags = tagsTitles.Select(x => new Tag
        {
            Title = x,
        });
        context.Tags.AddRange(tags);//.ToList();
        var response = await context.SaveChangesAsync(token);

        return tags;
    }
    public async Task<bool> EditArticle(int id, Edit.Request req, CancellationToken token = default)
    {
        var tags = await InsertTags(req.Tags, token);

        using var context = _context;
        var entity = await context.Articles
            .Where(x => x.ArticleId == id)
            .FirstOrDefaultAsync();
        if(entity == null)
        {
            return false;
        }
        entity.ArticleName = req.ArticleName;
        entity.ArticleDescription = req.ArticleDescription;

        var result = await context.SaveChangesAsync(token);

        return result != 0;



    }



}
