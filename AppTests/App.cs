using System.Data.Common;
using System.Net;
using System.Text.Json;
using ASPFastApi;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Testing;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Testcontainers.PostgreSql;
using GetArticles = ASPFastApi.Features.Public.GetArticles;
using AddArticle = ASPFastApi.Features.Public.AddArticle;
namespace AppTests;

public class App : AppFixture<Program>
{
    private readonly PostgreSqlContainer _container = new PostgreSqlBuilder().Build();


    private const string Database = "master";
    private const string Username = "sa";
    private const string Password = "$trongPassword";
    private const ushort MsSqlPort = 1433;
    
    public WebApplicationFactory<Program> _factory;
    // private IContainer _container;
    protected async override Task SetupAsync()
    {
        await _container.StartAsync();
        DbConnection connection = new NpgsqlConnection(_container.GetConnectionString());
        
        
            
            _factory = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddDbContext<ApplicationContext>(options =>
                        options.UseNpgsql(_container.GetConnectionString()));
                });
            });

        // Initialize database
        using var scope = _factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        dbContext.Database.Migrate();
        // place one-time setup code here
    }
    //
    // protected override void ConfigureApp(IWebHostBuilder a)
    // {
    //     
    //     // do host builder config here
    // }
    //
    // protected override void ConfigureServices(IServiceCollection s)
    // {
    //     // do test service registration here
    // }
    //
    [Fact]
    public async Task RandomTest()
    {
        var client = _factory.CreateClient();

        
            // var (rsp, res) = await client.
            //     GETAsync<GetArticles.Endpoint, IEnumerable<GetArticles.Response>>();
            //
            //
            
            var (rsp, res) = await client.
                POSTAsync<AddArticle.Endpoint, AddArticle.Request, ErrorResponse>(
                    new()
                    {
                        ArticleName = "test1",
                        ArticleDescription = "aaaaaaaaaraaaaaaaaar",
                        Visibility = false
                    });
            rsp.StatusCode.Should().Be(HttpStatusCode.OK);
            // using (DbConnection connection = new NpgsqlConnection(_container.GetConnectionString()))
            // {
            //     using (DbCommand command = new NpgsqlCommand())
            //     {
            //         
            //         connection.Open();
            //         command.Connection = connection;
            //         command.CommandText = "SELECT 1";
            //     }
            // }
        //
        // rsp.Response.EnsureSuccessStatusCode();
        // var content = await res.Response.Content.ReadAsStringAsync();
        // var allresident "done"sResponse = JsonSerializer.Deserialize(content);
        //
        // allresidentsResponse.Should().NotBeNull();
        // allresidentsResponse.residents.Should().NotBeNull();
        // allresidentsResponse.residents.Should().BeEmpty();
    }
    protected async override Task TearDownAsync()
    {
        // await _container.StopAsync();
        // await _container.DisposeAsync();
        // _factory.Dispose();
        // // do cleanups here
        _container.DisposeAsync().AsTask();
    }
}