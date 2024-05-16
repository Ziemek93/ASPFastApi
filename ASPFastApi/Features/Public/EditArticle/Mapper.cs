using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.EditArticle;
public class Mapper : Mapper<Request, Response, Article>, IResponseMapper
{
    public override Request FromEntity(Article e)
    {
        return base.FromEntity(e);
    }


    public override Article ToEntity(Request a) => new() // to db - setp 2
    {
        ArticleName = a.ArticleName,
        ArticleDescription = a.ArticleDescription,
        Visibility = a.Visibility,
        Tags = a.Tags.Select(c => c.Title).ToList(),//a.Tags.Select(t => t.Title)
    };
}
