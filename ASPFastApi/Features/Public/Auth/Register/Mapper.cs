using ASPFastApi.Features.Public.GetArticles;
using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Public.Auth.Register;

public class UserMapper : Mapper<Request, object, User>, IResponseMapper
{
    
    public override User ToEntity(Request am) => new() // from user - step 1
    {
        Username = am.Username,
        Password = am.Password
    };

}