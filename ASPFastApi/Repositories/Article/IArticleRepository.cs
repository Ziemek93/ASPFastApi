using ASPFastApi.Features.Public.AddArticle;
using ASPFastApi.Models.Entities;

namespace ASPFastApi.Repositories.Articles
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticles(CancellationToken token = default);
        Task<Article?> GetArticle(int id, CancellationToken token = default);
        Task<int> AddArticle(Article article, CancellationToken token = default);
        Task<bool> CategoryExist(Article article, CancellationToken token = default);
        Task<bool> ArticleExist(Article article, CancellationToken token = default);
        Task<bool> EditArticle(Article request, CancellationToken token = default);
    }
}
