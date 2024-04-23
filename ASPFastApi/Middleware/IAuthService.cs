using FastApi.Entity;

namespace ASPFastApi.Middleware;

public interface IAuthService
{
    public Task<Response?> Authenticate(Request model);
    public Task<string> generateJwtToken(User user);


}