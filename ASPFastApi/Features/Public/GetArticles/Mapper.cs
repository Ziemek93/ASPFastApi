namespace ASPFastApi.Features.Public.GetArticles;

public class Mapper : Mapper<Request, object, Dom.Article.Comment>
{
    public override Article ToEntity(Request r) => new()
    {
        Content = r.Comment,
        NickName = r.NickName,
        ID = ObjectId.GenerateNewId().ToString(),
        DateAdded = DateTime.UtcNow
    };
}