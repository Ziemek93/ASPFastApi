using ASPFastApi.Models;
using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Services.ArticleService;
using FastEndpoints;

namespace ASPFastApi.Features.Public.GetArticle;

public class Endpoint : EndpointWithoutRequest<ResponseObject<ArticleDto>, ArticleMapper>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Get("/api/article/{id}");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        int articleID = Route<int>("Id");
        var response = await _service.GetArticleAsync(articleID, Map.FromEntity);

        if (response.responseCode != Models.Enums.ResponseEnum.Ok)
        {
            //throw new BadHttpRequestException("Artykuł nie został dodany");
            //await SendNotFoundAsync(ct);
            //await SendForbiddenAsync(ct);
            //await SendAsync(ResultResponse, 403, ct);
            //await SendStringAsync(ResponsResult.ToString(), 403);
        }
        //var dto = Map.FromEntity(ResponsResult.resultResponse);

        await SendAsync(response.ResponsResult, (int)response.responseCode);
    }

}
