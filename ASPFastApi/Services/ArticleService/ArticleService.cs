using ASPFastApi.Middleware;
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
        public async Task<ResponseTuple<IEnumerable<Article>, ResponseEnum>> GetArticles(CancellationToken token = default)
        {
            var result = await _articlerepository.GetArticles(token);
            var response = new ResponseTuple<IEnumerable<Article>, ResponseEnum>(result, ResponseEnum.Ok);

            return response;
        }
        public async Task<ResponseTuple<Article, ResponseEnum>> AddArticle(Article article, CancellationToken token = default)
        {
            var response = new ResponseTuple<Article, ResponseEnum>();

            var categoryExists = await _articlerepository.CategoryExist(article);
            if (!categoryExists)
            {
                //throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
                response = response.Make(article, ResponseEnum.BadRequestArguments, "Kategoria o takim id nie istnieje");
            }
            else
            {
                var result = await _articlerepository.AddArticle(article, token);
                if (result == 0) {
                    response = response.Make(article, ResponseEnum.BadRequestArguments, "Nie można utworzyć artykułu.");
                }
                response = response.Make(article, ResponseEnum.Ok);


            }
                return response;

        }
        
        public async Task<ResponseTuple<bool, ResponseEnum>> EditArticle(Article article, CancellationToken token = default)
        {
            var response = new ResponseTuple<bool, ResponseEnum>();

            var result = await _articlerepository.EditArticle(article);


            if (!result)
            {
                //throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
                response = response.Make(false, ResponseEnum.BadRequestArguments, "Nie udało się, ups i chuj");
            }
            else
            {
                response = response.Make(true, ResponseEnum.Ok, "Sukkes");


            }
                return response;

        }
        public async Task<ResponseTuple<Article, ResponseEnum>> GetArticle(int id, CancellationToken token = default)
        {
            var response = new ResponseTuple<Article, ResponseEnum>();

            var result = await _articlerepository.GetArticle(id, token);
            if (result != null)
            {
                return response.Make(result, ResponseEnum.NotFound, "Nie znaleziono artykułu");
            }
            return response.Make(result, ResponseEnum.Ok);

        }


    }
}

