using ASPFastApi.Models;
using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Models.Entities;
using ASPFastApi.Services.ArticleService;
using FastEndpoints;
namespace ASPFastApi.Features.Private.AddArticle;

public class Endpoint : Endpoint<AddArticleDao, ResponseObject<Article>, ArticleMapper>
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

    public override async Task HandleAsync(AddArticleDao req, CancellationToken token = default)
    {
        var article = Map.ToEntity(req);
        var response = await _service.AddArticleAsync(article, token);

        await SendAsync(response.ResponsResult, (int)response.responseCode, token);
    }

}