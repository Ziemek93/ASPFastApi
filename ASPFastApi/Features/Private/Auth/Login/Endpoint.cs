using ASPFastApi.Middleware;
using FastEndpoints;

namespace ASPFastApi.Features.Private.Auth.Login;

public class Endpoint : Endpoint<Request, Response, LoginMapper>
{


    private readonly IAuthService _jwtService;

    public Endpoint(IAuthService jwtService)
    {
        _jwtService = jwtService;
    }

    public override void Configure()
    {
        Post("/api/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken c)
    {
        //user credential checking has been omitted for brevity

        var response = await _jwtService.Authenticate(request);
        if (response == null)
        {
            throw new BadHttpRequestException("Wrong username or password");
        }
        await SendAsync(
            response
            );

    }
}