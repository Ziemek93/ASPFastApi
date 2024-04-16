using ASPFastApi.Middleware;
using FastEndpoints;
using FastEndpoints.Security;

namespace ASPFastApi.Features.Public.User;


public class Endpoint : Endpoint<LoginRequest>

{
    public override void Configure()
    {
        Post("/api/login");
        AllowAnonymous();
    }
//https://tutorials.eu/jwt-authentication-in-asp-net-core/
//https://fast-endpoints.com/docs/security#jwt-bearer-authentication
    public override async Task HandleAsync(LoginRequest req, CancellationToken ct)
    {
        if (await AuthService.CredentialsAreValid(req.Username, req.Password, ct))
        {
            var jwtToken = JwtBearer.CreateToken(
                o =>
                {
                    o.SigningKey = "testjwttestjwttestjwttestjwttestjwttestjwttestjwttestjwt";
                    o.ExpireAt = DateTime.UtcNow.AddDays(1);
                    o.User.Roles.Add("Manager", "Auditor");
                    o.User.Claims.Add(("UserName", req.Username));
                    o.User["UserId"] = "001"; //indexer based claim setting
                });

            await SendAsync(
                new
                {
                    req.Username,
                    Token = jwtToken
                });
        }
        else
            ThrowError("The supplied credentials are invalid!");
    }
}