using ASPFastApi.Middleware;

namespace ASPFastApi.Services.ArticleService
{

    public class ArticleService
    {
        private readonly IArticleService _articleService;

        public ArticleService(IArticleService articleService)
        {
            _articleService = articleService;
        }


    }
}

