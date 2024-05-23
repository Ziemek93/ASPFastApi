using ASPFastApi.Models.Entities;

namespace ASPFastApi.Features.Public.GetArticles;

public class Request
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
    public ICollection<Tag> Tags { get; set; }
}

public class Response
{
    public string ArticleName { get; set; } = null!;
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
    public List<String> Tags { get; set; }
    
    public virtual IEnumerable<CommentDto> Comments { get; set; }
    
    
}

public class TagDto
{
    public string Title { get; set; }
}

public class CommentDto
{
    public string Content { get; set; }
}