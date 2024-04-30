using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using AutoFixture;
using FastEndpoints;
using FastEndpoints.Testing;
using FluentAssertions;
using Xunit.Priority;
using GetArticles = ASPFastApi.Features.Public.GetArticles;
using AddArticle = ASPFastApi.Features.Public.AddArticle;

namespace AppTests;

public class TestsContainerBase : IClassFixture<TestsBase>, IDisposable
{
    private readonly WebApplicationFactory<Program> _webApplicationFactory;

    private readonly HttpClient _httpClient;

    public TestsContainerBase(TestsBase fixture)
    {
        var clientOptions = new WebApplicationFactoryClientOptions();
        clientOptions.AllowAutoRedirect = false;
        _httpClient = fixture._factory.CreateClient(clientOptions);
    }

    public void Dispose()
    {
        _webApplicationFactory.Dispose();
    }
    
    [Fact]
    public async Task GetResultCode200()
    {
        // var (prsp, pres) = await app.Client.POSTAsync<GetArticles.Endpoint, GetArticles.Request, ErrorResponse>(new()
        // {
        // });
             
        var (rsp, res) = await _httpClient.
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
             
        var (rsp, res) = await _httpClient.
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
}