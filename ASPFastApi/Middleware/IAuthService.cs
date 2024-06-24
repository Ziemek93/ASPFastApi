using ASPFastApi.Features.Private.Auth.Login;
using ASPFastApi.Models.Entities;

namespace ASPFastApi.Middleware;

public interface IAuthService
{
    public Task<Response?> Authenticate(Request model);
    public Task<string> generateJwtToken(User user);


}