using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Models.Entities;
using ASPFastApi.Models.Enums;
using ASPFastApi.Repositories.Articles;

namespace ASPFastApi.Services.ArticleService
{

    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articlerepository;

        public ArticleService(IArticleRepository articlerepository)
        {
            _articlerepository = articlerepository;
        }

        public async Task<ResponseTuple<Article, ResponseEnum>> AddArticleAsync(Article article, CancellationToken token = default)
        {
            var response = new ResponseTuple<Article, ResponseEnum>();
            //var articleDtop = mapper(article);

            var categoryExists = await _articlerepository.CategoryExistAsync(article.CategoryId, token);
            if (!categoryExists)
            {
                //throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
                response = response.Make(article, ResponseEnum.BadRequest, "Kategoria o takim id nie istnieje");
            }
            else
            {
                var result = await _articlerepository.AddArticleAsync(article, token);
                if (result == 0)
                {
                    response = response.Make(article, ResponseEnum.BadRequest, "Nie można utworzyć artykułu.");
                }
                response = response.Make(article, ResponseEnum.Ok);


            }
            return response;

        }

        public async Task<ResponseTuple<bool, ResponseEnum>> EditArticleAsync(int id, ArticleDao article, CancellationToken token = default)
        {
            var response = new ResponseTuple<bool, ResponseEnum>();

            var result = await _articlerepository.EditArticleAsync(id, article);


            if (!result)
            {
                //throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
                response = response.Make(false, ResponseEnum.BadRequest, "Nie udało się, ups i chuj");
            }
            else
            {
                response = response.Make(true, ResponseEnum.Ok, "Sukkes");


            }
            return response;

        }
        public async Task<ResponseTuple<IEnumerable<ArticleDto>, ResponseEnum>> GetArticlesAsync(Func<Article, ArticleDto> mapper, CancellationToken token = default)
        {
            var result = await _articlerepository.GetArticlesAsync(token);
            var response = new ResponseTuple<IEnumerable<ArticleDto>, ResponseEnum>();

            var mappedResult = result.Select(x => mapper(x));
            var type = typeof(ArticleService).GetProperty("mappedResult");
            response = response.Make(mappedResult, ResponseEnum.Ok);
            //new ResponseTuple<IEnumerable<ArticleDto>, ResponseEnum>(mappedResult, ResponseEnum.Ok);

            return response;
        }
        public async Task<ResponseTuple<ArticleDto, ResponseEnum>> GetArticleAsync(int id, Func<Article, ArticleDto> mapper, CancellationToken token = default)
        {
            var response = new ResponseTuple<ArticleDto, ResponseEnum>();

            var result = await _articlerepository.GetArticleAsync(id, token);

            if (result == null)
            {
                return response.Make(null, ResponseEnum.NotFound, "Nie znaleziono artykułu");
            }
            return response.Make(mapper(result), ResponseEnum.Ok);

        }
        public async Task<ResponseTuple<bool, ResponseEnum>> DeleteArticleAsync(int id, CancellationToken token = default)
        {
            var response = new ResponseTuple<bool, ResponseEnum>();


            var result = await _articlerepository.DeleteArticleAsync(id, token);
            if (result)
            {
                return response.Make(result, ResponseEnum.Ok, "Usunięto pomyślnie.");

            }
            return response.Make(result, ResponseEnum.BadRequest, "Nie mogę usunąć artykułu");


        }


    }
}

