using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Private.Auth.Login;

public class LoginMapper : Mapper<Request, object, User>, IResponseMapper
{
    // public int Id { get; set; }
    // public string Username { get; set; }
    // public string Token { get; set; }

    public override User ToEntity(Request request) => new()
    {
        Username = request.Username,
        Password = request.Password
    };

    public override Response? FromEntity(User user) => new()
    {
        Username = user.Username,
        Token = ""
    };

}
