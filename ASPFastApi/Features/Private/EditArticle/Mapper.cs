using ASPFastApi.Models.ArticlesDao;
using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Private.EditArticle;
public class Mapper : Mapper<ArticleDao, object, Article>, IResponseMapper
{
    public override Article ToEntity(ArticleDao a) => new() // to db - setp 2
    {
        ArticleName = a.ArticleName,
        ArticleDescription = a.ArticleDescription,
        Visibility = a.Visibility,
        //Tags = (ICollection<Tag>)a.Tags.Select(t => new Tag
        //{
        //    Title = t.Title
        //}).AsEnumerable(),
    };
}
