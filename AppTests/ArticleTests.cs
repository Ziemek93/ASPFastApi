using System.Net;
using FastEndpoints;
using FastEndpoints.Testing;
using FluentAssertions;
using Xunit.Priority;
using GetArticles = ASPFastApi.Features.Public.GetArticles;
using AddArticle = ASPFastApi.Features.Public.AddArticle;
namespace AppTests
{
    public class ArticleTests(App app) : TestBase<App>
    {

        [Fact]
        public async Task GetResultCode200()
        {
            // var (prsp, pres) = await app.Client.POSTAsync<GetArticles.Endpoint, GetArticles.Request, ErrorResponse>(new()
            // {
            // });
             
            var (rsp, res) = await app.Client.
                GETAsync<GetArticles.Endpoint, IEnumerable<GetArticles.Response>>();
            
            rsp.StatusCode.Should().Be(HttpStatusCode.OK);
            //res.Select(a => a.ArticleName).Should().Equal(App.ArticleName);test
            

        }       
        [Fact]
        public async Task TestTest()
        {
            // var (prsp, pres) = await app.Client.POSTAsync<GetArticles.Endpoint, GetArticles.Request, ErrorResponse>(new()
            // {
            // });
             
            var (rsp, res) = await app.Client.
                POSTAsync<AddArticle.Endpoint, AddArticle.Request, ErrorResponse>(
                    new()
                    {
                        // ArticleName = "ababababccababccababccababccababccababcccc",
                        ArticleName = "ababcc",
                        ArticleDescription = "ababcc",
                        Visibility = false
                    });

            rsp.StatusCode.Should().Be(HttpStatusCode.OK);
            //res.Select(a => a.ArticleName).Should().Equal(App.ArticleName);test
            

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