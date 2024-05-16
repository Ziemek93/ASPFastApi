using ASPFastApi.Auth;
using ASPFastApi.Services.ArticleService;
using FastApi.Context;
using FastEndpoints;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;

namespace ASPFastApi.Features.Public.GetArticles;

public class Endpoint : EndpointWithoutRequest<IEnumerable<Response>?, ArticleMapper>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Get("/api/articles");
        //AllowAnonymous();
        Roles("Admin", "Manager");
        Claims("Username", "EmployeeID");
        // AccessControl("Article_Create");
        // Permissions(Allow.Article_Create);



    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        var result = await _service.GetArticles();

        var response = result.resObj.Select(x => Map.FromEntity(x));

            
        
        await SendAsync(response, 200);
    }

}
