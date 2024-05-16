using ASPFastApi.Models.Entities;
using Azure.Core;
using FastEndpoints;
using MongoDB.Bson;

namespace ASPFastApi.Features.Public.GetArticle;

public class ArticleMapper : Mapper<int, object, Article>, IResponseMapper
{

    //public override Request ToEntity(Article a) => new() // to db - setp 2
    //{
    //    ArticleName = a.ArticleName,
    //    ArticleDescription = a.ArticleDescription,
    //    Visibility = a.Visibility,
    //    Comments = a.Comments.Select(c => new CommentDto()
    //    {
    //        Content = c.Content
    //    }),
    //    Tags = a.Tags.Select(c => c.Title).ToList(),//a.Tags.Select(t => t.Title)
    //};
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