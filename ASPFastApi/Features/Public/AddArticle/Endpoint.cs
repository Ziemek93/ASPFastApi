using FastApi.Context;
using FastApi.Entity;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
namespace ASPFastApi.Features.Public.AddArticle;

public class Endpoint : Endpoint<Request, Response, ArticleMapper>
{
    private readonly ApplicationContext _context;


    public Endpoint(ApplicationContext context)
    {
        _context = context;
    }
    public override void Configure()
    {
        Post("/api/article/create");
        // AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        var categoryExists = _context.Categories.Where(c => c.CategoryId == req.CategoryId).Any();
        if (!categoryExists)
        {
            throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
        }
        
        var articleEntity = _context.Articles.Add(Map.ToEntity(req));
        var result = await _context.SaveChangesAsync();
        
        if (result == 0)
        {
            throw new BadHttpRequestException("Artykuł nie został dodany");
        }
        var createdArticle = await _context.Articles.Include(ar => ar.Category)
            .Where(article => article.ArticleId == articleEntity.Entity.ArticleId).SingleOrDefaultAsync();
        // await SendAsync(null, 200, default);
        
        await SendAsync(Map.FromEntity(createdArticle));
        
    }

}