using Edit = ASPFastApi.Features.Public.EditArticle;
using ASPFastApi.Models.Entities;
using ASPFastApi.Models.Enums;
using ASPFastApi.Repositories.Articles;

namespace ASPFastApi.Services.ArticleService
{
    public interface IArticleService
    {
        Task<ResponseTuple<IEnumerable<Article>, ResponseEnum>> GetArticles(CancellationToken token = default);
        Task<ResponseTuple<Article, ResponseEnum>> GetArticle(int id, CancellationToken token = default);
        Task<ResponseTuple<Article, ResponseEnum>> AddArticle(Article article, CancellationToken token = default);
        Task<ResponseTuple<bool, ResponseEnum>> EditArticle(int id, Edit.Request article, CancellationToken token = default);
        //ResponseTuple<IEnumerable<Article>, ASPFastApi.Models.Enums.ResponseEnum>
    }
}