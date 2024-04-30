using ASPFastApi.Features.Public.AddArticle;

namespace ASPFastApi.Repositories.Article
{
    public interface IArticleRepository
    {
        public Task<IEnumerable<Response>> GetArticles(ArticleMapper mapper);

    }
}
