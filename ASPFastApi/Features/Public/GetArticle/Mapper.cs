using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.GetArticle;

public class ArticleMapper : Mapper<int, ArticleDto, Article>, IResponseMapper
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
    public override ArticleDto FromEntity(Article a) => new() // to db - setp 2
    {
        ArticleName = a.ArticleName,
        ArticleDescription = a.ArticleDescription,
        Visibility = a.Visibility,
        Comments = a.Comments.Select(c => new ArticleCommentDto()
        {
            Content = c.Content
        }),
        Tags = a.Tags.Select(c => c.Title).ToList(),//a.Tags.Select(t => t.Title)
    };
}