using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.EditArticle;
public class Mapper : Mapper<Request, Response, Article>, IResponseMapper
{
    public override Article ToEntity(Request a) => new() // to db - setp 2
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
