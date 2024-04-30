using System.Text;
using ASPFastApi.Middleware;
using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.IdentityModel.Tokens;

namespace ASPFastApi.Features.Public.Auth.Register;


public class Endpoint : Endpoint<Request, Response, UserMapper>
{
    private IConfiguration _config { get; set; }
    public ApplicationContext _context { get; set; }

    public Endpoint(IConfiguration config, ApplicationContext context)
    {
        _config = config;
        _context = context;
    }

    public override void Configure()
    {
        Post("/api/register");
        AllowAnonymous();
    }
//https://tutorials.eu/jwt-authentication-in-asp-net-core/
//https://fast-endpoints.com/docs/security#jwt-bearer-authentication
    public override async Task HandleAsync(Request request, CancellationToken ct)
    {
        // if (await AuthService.CredentialsAreValid(req.Username, req.Password, ct))
        // {
            // string authKey = _config.GetSection("Auth").GetSection("ApiKey").Value;
            // // var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authKey));
            // // var t = signingKey.KeyId;
            // var jwtToken = JwtBearer.CreateToken(
            //     o =>
            //     {
            //         o.SigningKey = authKey;
            //         o.ExpireAt = DateTime.UtcNow.AddDays(1);
            //         o.User.Roles.Add("Manager", "Auditor");
            //         o.User.Claims.Add(("UserName", req.Username));
            //         o.User["UserId"] = "001"; //indexer based claim setting
            //     });
            var user = await _context.User.AddAsync(Map.ToEntity(request));// Data.CreateUser(Map.ToEntity(r));
            var result = await _context.SaveChangesAsync();

            if (result == 0)
                ThrowError("User creation failed!");

            Response.Message = $"The user [{request.Username}] has been created.";

            // await SendAsync(
            //     new
            //     {
            //        Message = "Account created"
            //     });
        }

    }

