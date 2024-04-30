using ASPFastApi.Auth;
using FastApi.Context;
using FastApi.Entity;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace ASPFastApi.Features.Public.GetArticles;

public class Endpoint : EndpointWithoutRequest<List<Response>, ArticleMapper>
{    
    public ApplicationContext context { get; set; }

    public override void Configure()
    {
        Get("/api/article");
        //  AllowAnonymous();
        Roles("Admin", "Manager");
        Claims("Username", "EmployeeID");
        // AccessControl("Article_Create");
        // Permissions(Allow.Article_Create);



    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        //alternative for SendAsync()
        // var result = await Data.GetArticles(context);
        var result = context.Articles
            .Include(a => a.Comments)
            .Include(a => a.Tags)
            .ToList(); //GetArticles(context);

        var entity = result.Select(a => 
            Map.FromEntity(a))
            .OrderBy(a => a.ArticleName)
            .ToList();
            
        
        await SendAsync(entity, 200);
    }

}

public class TestClass
{
    public string t1 { get; set; }
    public string t2 { get; set; }
}