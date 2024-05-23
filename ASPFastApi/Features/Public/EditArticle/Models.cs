using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.EditArticle;

public class Request
{
    public int ArticleId { get; set; }
    public string ArticleName { get; set; }
    public string? ArticleDescription { get; set; }
    public bool Visibility { get; set; }
    public ICollection<CommentDto> Tags { get; set; }
}


public class Response
{


}

public class TagDto
{
    public string Title { get; set; }
}

public class CommentDto
{
    public string Content { get; set; }
}

internal sealed class Validator : Validator<Request>
{
    public Validator()
    {

    }
}

