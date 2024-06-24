using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Models.Entities;
using ASPFastApi.Models.Enums;

namespace ASPFastApi.Services.ArticleService
{
    public interface IArticleService
    {
        Task<ResponseTuple<IEnumerable<ArticleDto>, ResponseEnum>> GetArticlesAsync(Func<Article, ArticleDto> mapper, CancellationToken token = default);
        Task<ResponseTuple<ArticleDto, ResponseEnum>> GetArticleAsync(int id, Func<Article, ArticleDto> mapper, CancellationToken token = default);
        Task<ResponseTuple<Article, ResponseEnum>> AddArticleAsync(Article article, CancellationToken token = default);
        Task<ResponseTuple<bool, ResponseEnum>> EditArticleAsync(int id, ArticleDao article, CancellationToken token = default);
        Task<ResponseTuple<bool, ResponseEnum>> DeleteArticleAsync(int id, CancellationToken token = default);
        //ResponseTuple<IEnumerable<Article>, ASPFastApi.Models.Enums.ResponseEnum>
    }
}