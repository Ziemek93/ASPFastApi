using ASPFastApi.Models.Entities;
using Azure.Core;
using FastEndpoints;
using MongoDB.Bson;

namespace ASPFastApi.Features.Public.GetArticles;

public class ArticleMapper : Mapper<Request, object, Article>, IResponseMapper
{
    
    public override Article ToEntity(Request am) => new() // from user - step 1
    {
        ArticleName = am.ArticleName,
        ArticleDescription = am.ArticleDescription,
        Visibility = am.Visibility,
        Tags = am.Tags
    };
    public override Response FromEntity(Article a) => new() // to db - setp 2
    {
        ArticleName = a.ArticleName,
        ArticleDescription = a.ArticleDescription ,
        Visibility =  a.Visibility,
        Comments = a.Comments.Select(c => new CommentDto()
        {
            Content = c.Content
        }),
        Tags = a.Tags.Select(c => c.Title).ToList(),//a.Tags.Select(t => t.Title)
    };
}