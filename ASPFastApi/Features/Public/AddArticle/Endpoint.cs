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

        //alternative for SendAsync()
        // var result = await Data.GetArticles(context);
        // var r = _context.Articles.Add(Map.FromEntity(req));

        // var result = _context.Articles.Include(a => a.Comments).ToList(); //GetArticles(context);
        //
        // var entity = result.Select(a => Map.FromEntity(a)).ToList();
        // var abc = Map.ToEntity(req);
        _context.Articles.Add(Map.ToEntity(req));
        var result = await _context.SaveChangesAsync();
        // await SendAsync(null, 200, default);
        await SendAsync(new()
        {
            ArticleName = "done",
            ArticleDescription =  "done",
            Visibility = false
        });
        
    }

}