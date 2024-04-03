using FastEndpoints;

namespace ASPFastApi.Features.Public.GetArticles;

public class Endpoint : EndpointWithoutRequest<List<ArticleModel>>
{    
    public FastApi.Context.AppContext context { get; set; }

    public override void Configure()
    {
        Get("/api/article");
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        //alternative for SendAsync()
        Response = await Data.GetArticles(context);
    }

}