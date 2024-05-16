using ASPFastApi.Models.Entities;

namespace ASPFastApi.Features.Public.AddArticle;

public class Request
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    
    public int CategoryId { get; set; }
    
    public ICollection<Tag> Tags { get; set; }
    public bool Visibility { get; set; }
}

public class Response
{
    public int ArticleId { get; set; }
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public Category Category { get; set; }
    public bool Visibility { get; set; }
    public ICollection<Tag> Tags { get; set; }
    
    public virtual ICollection<Comment> Comments { get; set; }
    
    
}