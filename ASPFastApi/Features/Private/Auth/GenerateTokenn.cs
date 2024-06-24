// using ASPFastApi.Features.Public.Login;
// using FastApi.Context;
// using FastEndpoints;
// using FastEndpoints.Security;
//
// namespace ASPFastApi.Middleware;
//
// public class UserTokenService : RefreshTokenService<TokenRequest, Response>
// {
//     private readonly IAuthService _jwtService;
//     
//     public UserTokenService(IConfiguration config, IAuthService jwtService)
//     {
//         Setup(x =>
//         {
//             x.TokenSigningKey = config["JWTSigningKey"];
//             x.AccessTokenValidity = TimeSpan.FromMinutes(1);
//             x.RefreshTokenValidity = TimeSpan.FromHours(1);
//             x.Endpoint("/user/auth/refresh-token", ep =>
//             {
//                 ep.Summary(s => s.Description = "this is the refresh token endpoint");
//             });
//         });
//     }
//
//     public override Task PersistTokenAsync(Response rsp)
//     {
//         return Data.StoreToken(rsp.UserId, rsp.RefreshExpiry, rsp.RefreshToken);
//     }
//
//     public override async Task RefreshRequestValidationAsync(TokenRequest req)
//     {
//         if (!await Data.TokenIsValid(req.UserId, req.RefreshToken))
//             AddError("The refresh token is not valid!");
//     }
//
//     public override async Task SetRenewalPrivilegesAsync(TokenRequest request, UserPrivileges privileges)
//     {
//         await Task.Delay(100); //simulate a db call
//         privileges.Claims.Add(new("UserID", request.UserId));
//         privileges.Permissions.AddRange(new Allow().AllCodes());
//     }
// }
