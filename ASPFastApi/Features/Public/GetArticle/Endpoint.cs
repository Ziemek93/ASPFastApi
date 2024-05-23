using ASPFastApi.Auth;
using ASPFastApi.Services.ArticleService;
using FastApi.Context;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace ASPFastApi.Features.Public.GetArticle;

public class Endpoint : EndpointWithoutRequest<Response, ArticleMapper>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Get("/api/article/{id}");
        //  AllowAnonymous();
        Roles("Admin", "Manager");
        Claims("Username", "EmployeeID");
        // AccessControl("Article_Create");
        // Permissions(Allow.Article_Create);



    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        int articleID = Route<int>("Id");
        var response = await _service.GetArticle(articleID);

        if (response.resInfo != Models.Enums.ResponseEnum.Ok)
        {
            //throw new BadHttpRequestException("Artykuł nie został dodany");
            //await SendNotFoundAsync(ct);
            //await SendForbiddenAsync(ct);
            //await SendAsync(resObj, 403, ct);
            await SendStringAsync(response.ToString(), 403);
        }
        var result = Map.FromEntity(response.resObj);

        await SendAsync(result, 200);
    }

}
