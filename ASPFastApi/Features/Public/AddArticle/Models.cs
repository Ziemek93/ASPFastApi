using FastApi.Entity;

namespace ASPFastApi.Features.Public.AddArticle;

public class Request
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
}

public class Response
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
    
    public virtual ICollection<Comment> Comments { get; set; }
    
    
}