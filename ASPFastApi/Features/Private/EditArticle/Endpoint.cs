using ASPFastApi.Models;
using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Services.ArticleService;
using FastEndpoints;

namespace ASPFastApi.Features.Private.EditArticle;

internal sealed class Endpoint : Endpoint<ArticleDao, ResponseObject<bool>, Mapper>
{
    private readonly IArticleService _service;
    public Endpoint(IArticleService service)
    {
        _service = service;
    }
    public override void Configure()
    {
        Put("/api/article/{id}");
        Roles("Admin", "Manager");
        Claims("Username", "EmployeeID");
        // AccessControl("Article_Create");
        // Permissions(Allow.Article_Create);
    }

    public override async Task HandleAsync(ArticleDao request, CancellationToken token = default)
    {
        int articleID = Route<int>("Id");
        var article = request;//Map.ToEntity(req);
        var response = await _service.EditArticleAsync(articleID, request, token);
        await SendAsync(response.ResponsResult, (int)response.responseCode);
    }
}