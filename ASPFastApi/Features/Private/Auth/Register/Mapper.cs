using ASPFastApi.Models.Entities;
using FastEndpoints;

namespace ASPFastApi.Features.Private.Auth.Register;

public class UserMapper : Mapper<Request, object, User>, IResponseMapper
{

    public override User ToEntity(Request am) => new() // from user - step 1
    {
        Username = am.Username,
        Password = am.Password
    };

}