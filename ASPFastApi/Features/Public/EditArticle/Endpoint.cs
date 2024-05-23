using ASPFastApi.Services.ArticleService;
using FastEndpoints;

namespace ASPFastApi.Features.Public.EditArticle;

internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
    {
        private readonly IArticleService _service;

        public override void Configure()
        {
            Put("/api/article/{id}");
        }

        public override async Task HandleAsync(Request r, CancellationToken c)
        {
            int articleID = Route<int>("Id");
            var response = await _service.EditArticle(articleID);
        await SendAsync(new Response());
        }
    }
