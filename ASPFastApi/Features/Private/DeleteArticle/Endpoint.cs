using ASPFastApi.Models;
using ASPFastApi.Services.ArticleService;
using FastEndpoints;
namespace ASPFastApi.Features.Private.DeleteArticle;

public class Endpoint : Endpoint<RequestRoute, ResponseObject<bool>>
{
    private readonly IArticleService _service;


    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Delete("/api/article/{id}");
    }

    public override async Task HandleAsync(RequestRoute route, CancellationToken token = default)
    {
        //int id = Query<int>("id");
        var response = await _service.DeleteArticleAsync(route.Id);

        await SendAsync(response.ResponsResult, (int)response.responseCode, token);
        //await SendStringAsync(content: ResponsResult.ToString(), statusCode: (int)ResponsResult.responseCode, cancellation: token);
    }

}

public class RequestRoute
{
    [BindFrom("id")]
    public int Id { get; set; }
}