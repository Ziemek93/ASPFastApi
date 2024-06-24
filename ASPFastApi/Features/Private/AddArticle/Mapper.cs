using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Private.AddArticle;

public class ArticleMapper : Mapper<AddArticleDao, ArticleDtoExpanded, Article>, IResponseMapper
{
    public override Article ToEntity(AddArticleDao am) => new() // from user - step 1
    {
        ArticleName = am.ArticleName,
        CategoryId = am.CategoryId,
        ArticleDescription = am.ArticleDescription,
        Visibility = am.Visibility,
        Tags = am.Tags
    };

    //public override ArticleDtoExpanded FromEntity(Article a) => new() // to db - setp 2
    //{
    //    ArticleId = a.ArticleId,
    //    ArticleName = a.ArticleName,
    //    ArticleDescription = a.ArticleDescription,
    //    Category = a.Category,
    //    Visibility = a.Visibility,
    //    Comments = a.Comments,
    //    Tags = a.Tags
    //};

}