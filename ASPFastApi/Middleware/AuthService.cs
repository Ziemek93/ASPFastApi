using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ASPFastApi.Auth;
using ASPFastApi.Features.Public.Auth.Login;
using FastApi.Context;
using FastApi.Entity;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ASPFastApi.Middleware;

public class AuthService : IAuthService
{
    public ApplicationContext _context { get; set; }
    private IConfiguration _config { get; }

    public AuthService(ApplicationContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<Response?> Authenticate(Request model)
    {
        var user = await _context.User.SingleOrDefaultAsync(x =>
            x.Username == model.Username && x.Password == model.Password);
        // return null if user not found
        if (user == null) return null;

        // authentication successful so generate jwt token
        var token = await generateJwtToken(user);

        return new Response
        {
            Username = user.Username,
            Token = token
        };
    }

  
    public async Task<string> generateJwtToken(User user)
    {
        var key = _config.GetSection("Auth").GetSection("ApiKey").Value;
        var jwtToken = JwtBearer.CreateToken(
            o =>
            {
                o.SigningKey = key;
                o.ExpireAt = DateTime.UtcNow.AddMinutes(5);
                o.User.Roles.Add("Admin", "TestRoled");
                o.User.Claims.Add(("Username", user.Username));
                o.User["Username"] = user.Username;
                // o.User.Permissions.Add("Article_Create");
                // o.User["UserId"] = "001"; //indexer based claim setting
            });
 
        // var tokenHandler = new JwtSecurityTokenHandler();
        // var token = await Task.Run(() =>
        // {
        //     var authKey = _config.GetSection("Auth").GetSection("ApiKey").Value;
        //     var key = Encoding.ASCII.GetBytes(authKey);
        //     var tokenDescriptor = new SecurityTokenDescriptor
        //     {
        //         Subject = new ClaimsIdentity(new[] { new Claim("username", user.Username) }),
        //         Expires = DateTime.UtcNow.AddDays(7),
        //         SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
        //             SecurityAlgorithms.HmacSha256Signature)
        //     };
        //     return tokenHandler.CreateToken(tokenDescriptor);
        // });

        return jwtToken;
    }

 
}