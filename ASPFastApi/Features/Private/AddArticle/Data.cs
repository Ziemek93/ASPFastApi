//using ASPFastApi.Models.Entities;
//using FastApi.Context;
//using Microsoft.EntityFrameworkCore;

//namespace ASPFastApi.Features.Private.AddArticle;
////nie wiem po chuj to
//public class Data
//{
//    async internal static Task<List<Article>> AddArticle(ApplicationContext context, ArticleMapper mapper, Request req)
//    {
//        var categoryExists = context.Categories.Where(c => c.CategoryId == req.CategoryId).Any();
//        if (!categoryExists)
//        {
//            throw new BadHttpRequestException("Kategoria o takim id nie istnieje");
//        }

//        var articleEntity = context.Articles.Add(mapper.ToEntity(req));
//        var result = await context.SaveChangesAsync();

//        if (result == 0)
//        {
//            throw new BadHttpRequestException("Artykuł nie został dodany");
//        }
//        var createdArticle = await context.Articles.Include(ar => ar.Category)
//            .Where(article => article.ArticleId == articleEntity.Entity.ArticleId).SingleOrDefaultAsync();
//        // await SendAsync(null, 200, default);
//        var n = mapper.FromEntity(createdArticle);

//        return null;
//    }
//}