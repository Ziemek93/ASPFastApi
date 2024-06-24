using ASPFastApi.Models.ArticlesDto;
using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.GetArticles;

public class ArticleMapper : Mapper<object, ArticleDto, Article>, IResponseMapper
{

    //public override Article ToEntity(Request am) => new() // from user - step 1
    //{
    //    ArticleName = am.ArticleName,
    //    ArticleDescription = am.ArticleDescription,
    //    Visibility = am.Visibility,
    //    Tags = am.Tags
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
    //public override IEnumerable<ArticleDto> FromEntity(IEnumerable<Article> articles)
    //{
    //    var result = articles.Select(x => new ArticleDto
    //    {
    //        ArticleName = x.ArticleName,
    //        ArticleDescription = x.ArticleDescription,
    //        Visibility = x.Visibility,
    //        Comments = x.Comments.Select(c => new CommentDto()
    //        {
    //            Content = c.Content
    //        }),
    //        Tags = x.Tags.Select(c => c.Title).ToList(),//a.Tags.Select(t => t.Title)
    //    });
    //    return result;
    //}

}