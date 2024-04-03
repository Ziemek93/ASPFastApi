namespace ASPFastApi.Features.Public.GetArticles;

public class ArticleModel
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
}