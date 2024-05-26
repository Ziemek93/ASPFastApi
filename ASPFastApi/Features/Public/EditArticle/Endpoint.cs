using ASPFastApi.Services.ArticleService;
using FastEndpoints;

namespace ASPFastApi.Features.Public.EditArticle;

internal sealed class Endpoint : Endpoint<Request, bool, Mapper>
    {
        private readonly IArticleService _service;
        public Endpoint(IArticleService service)
        {
            _service = service;
        }
    public override void Configure()
        {
            Put("/api/article/{id}");
        }

        public override async Task HandleAsync(Request req, CancellationToken token = default)
        {
            int articleID = Route<int>("Id");
            var article = req;//Map.ToEntity(req);
            var response = await _service.EditArticle(articleID, req, token);
            await SendAsync(true, 200);
        }
    }
