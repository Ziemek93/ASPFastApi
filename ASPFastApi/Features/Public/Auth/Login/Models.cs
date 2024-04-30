using FastEndpoints.Security;

namespace ASPFastApi.Features.Public.Auth.Login;

public class Request
{
    public string Username { get; set; }
    public string Password{ get; set; }
}

public class Response
{
    public string Username { get; set; }
    public string Token { get; set; }
}

// public class Validator : Validator<Request>
// {
//     public Validator()
//     {
//         RuleFor(x => x.Username).MinimumLength(5); 
//         RuleFor(x => x.Password).MinimumLength(5).MaximumLength(20);
//     }
// }