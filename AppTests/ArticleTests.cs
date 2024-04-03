using System.Net;
using FastEndpoints;
using FastEndpoints.Testing;
using FluentAssertions;
using Xunit.Priority;
using GetArticles = ASPFastApi.Features.Public.GetArticles;
namespace AppTests
{
    public class ArticleTests(App app) : TestBase<App>
    {
        [Fact]
        public async Task Invalid_User_Input()
        {
            // var (prsp, pres) = await app.Client.POSTAsync<GetArticles.Endpoint, GetArticles.Request, ErrorResponse>(new()
            // {
            // });
            
            var (rsp, res) = await app.Client.GETAsync<GetArticles.Endpoint, IEnumerable<GetArticles.Response>>();

            rsp.StatusCode.Should().Be(HttpStatusCode.OK);
            //res.Select(a => a.ArticleName).Should().Equal(App.ArticleName);
            

        }

        
        // [Fact, Priority(2)]
        // public async Task Valid_User_Input()
        // {
        //     var (rsp, res) = await App.Client.POSTAsync<Endpoint, Request, Response>(new()
        //     {
        //         FirstName = "Mike",
        //         LastName = "Kelso"
        //     });
        //     rsp.IsSuccessStatusCode.Should().BeTrue();
        //     res.Message.Should().Be("Hello Mike Kelso...");
        // }
    }
}