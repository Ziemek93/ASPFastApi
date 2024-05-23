using ASPFastApi.Models.Entities;

namespace ASPFastApi.Features.Public.EditArticle
{
    public interface IMapper
    {
        Request ToEntity(Article a);
    }
}