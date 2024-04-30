using FastEndpoints;
using FluentValidation;

namespace ASPFastApi.Features.Public.Auth.Register;

public class Request
{
    public string Username { get; set; }
    public string Password{ get; set; }
}

public class Response
{
    public string Message { get; set; }
}

public class Validator : Validator<Request>
{
    public Validator()
    {
        RuleFor(x => x.Username).MinimumLength(5); 
        RuleFor(x => x.Password).MinimumLength(5).MaximumLength(20);
    }
}