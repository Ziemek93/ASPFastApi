using ASPFastApi.Services.ArticleService;
using FastApi.Context;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
namespace ASPFastApi.Features.Public.AddArticle;

public class Endpoint : Endpoint<Request, Response, ArticleMapper>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Post("/api/article/create"); 
    }

    public override async Task HandleAsync(Request req, CancellationToken ct = default)
    { 
        var response = await _service.AddArticle(Map.ToEntity(req));
        var resObj = Map.FromEntity(response.resObj);

        if (response.resInfo != Models.Enums.ResponseEnum.Ok)
        {
            //throw new BadHttpRequestException("Artykuł nie został dodany");
            //await SendNotFoundAsync(ct);
            //await SendForbiddenAsync(ct);
            //await SendAsync(resObj, 403, ct);
            await SendStringAsync(response.ToString(), 403);
        }

        await SendAsync(resObj, 204, ct);       
    }

}