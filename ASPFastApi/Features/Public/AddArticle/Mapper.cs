﻿using FastApi.Entity;
using FastEndpoints;

namespace ASPFastApi.Features.Public.AddArticle;

public class ArticleMapper : Mapper<Request, object, Article>, IResponseMapper
{
    public override Article ToEntity(Request am) => new() // from user - step 1
    {
        ArticleName = am.ArticleName,
        ArticleDescription = am.ArticleDescription,
        Visibility = am.Visibility
    };
    
    public override Response FromEntity(Article a) => new() // to db - setp 2
    {
        ArticleName = a.ArticleName,
        ArticleDescription = a.ArticleDescription,
        Visibility = a.Visibility,
        Comments = a.Comments
    };

}