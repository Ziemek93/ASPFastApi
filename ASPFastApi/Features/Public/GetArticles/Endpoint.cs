using ASPFastApi.Models;
using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Services.ArticleService;
using FastEndpoints;

namespace ASPFastApi.Features.Public.GetArticles;

public class Endpoint : EndpointWithoutRequest<ResponseObject<IEnumerable<ArticleDto>?>, ArticleMapper>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Get("/api/articles");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken token = default)
    {
        var result = await _service.GetArticlesAsync(Map.FromEntity, token);

        // result.resultResponse.Select(x => Map.FromEntity(x));

        await SendAsync(result.ResponsResult, (int)result.responseCode);
    }

}
