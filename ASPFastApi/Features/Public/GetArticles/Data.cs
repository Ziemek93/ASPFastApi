using FastApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASPFastApi.Features.Public.GetArticles;

public class Data
{
    async internal static Task<List<ArticleModel>> GetArticles (FastApi.Context.AppContext context)
    {
        return await context.Find<Article>().ToListAsync();
    }
}