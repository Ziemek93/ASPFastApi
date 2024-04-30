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
using FluentAssertions.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Testcontainers.PostgreSql;
using GetArticles = ASPFastApi.Features.Public.GetArticles;
using AddArticle = ASPFastApi.Features.Public.AddArticle;

namespace AppTests;

public class TestsBase : IAsyncLifetime
{
    private PostgreSqlContainer _container;
    public WebApplicationFactory<Program> _factory;

    // public WebApplicationFactory<Program> _factory;

    // private IContainer _container;
    // protected override async Task SetupAsync()
    // {
    //     await _container.StartAsync();
    //     DbConnection connection = new NpgsqlConnection(_container.GetConnectionString());
    //
    //
    //     _factory = new WebApplicationFactory<Program>()
    //         .WithWebHostBuilder(builder =>
    //         {
    //             builder.ConfigureServices(services =>
    //             {
    //                 services.AddDbContext<ApplicationContext>(options =>
    //                     options.UseNpgsql(_container.GetConnectionString()));
    //             });
    //         });
    //
    //     // Initialize database
    //     using var scope = _factory.Services.CreateScope();
    //     var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
    //     dbContext.Database.Migrate();
    //     // place one-time setup code here
    // }


    public async Task InitializeAsync()
    {
        _container = new PostgreSqlBuilder().WithPortBinding(5432).WithUsername("$trongPassword").WithPassword("postgres").Build();
        await _container.StartAsync();

        _factory = new WebApplicationFactory<Program>();
        var _connectionString = new NpgsqlConnection(_container.GetConnectionString());

        _factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                services.Remove(services.SingleOrDefault(service =>
                    typeof(DbContextOptions<ApplicationContext>) == service.ServiceType));
                services.Remove(services.SingleOrDefault(service => typeof(DbConnection) == service.ServiceType));
                services.AddDbContext<ApplicationContext>((_, option) => { option.UseSqlServer(_connectionString); });
            });
        });
            using var scope = _factory.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            await dbContext.Database.MigrateAsync();
    }

    public async Task DisposeAsync()
    {
        await _container.DisposeAsync().AsTask();
    }

 

   
}