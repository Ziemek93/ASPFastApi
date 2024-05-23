using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

using System;
using ASPFastApi.Middleware;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ASPFastApi.Services.ArticleService;
using ASPFastApi.Repositories.Articles;

public class Program // Now public for easier accessibility
{
    static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
        builder.Services.AddScoped<ApplicationContext>();
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<IArticleService, ArticleService>();
        builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

      
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(conntectionString));
        //builder.Services.AddDbContext<FastApi.Context.ApplicationContext>(options => options.UseSqlServer(conntectionString));
        var apiKey = builder.Configuration.GetSection("Auth").GetSection("ApiKey").Value;
        var gId = builder.Configuration.GetSection("GoogleAuth").GetSection("id").Value;
        var gSecret = builder.Configuration.GetSection("GoogleAuth").GetSection("secret").Value;
       
        builder.Services
            .AddAuthenticationJwtBearer(s =>
            {
                s.SigningKey = apiKey;
            })
            .AddAuthorization()
            .AddFastEndpoints();
        // builder.Services.AddAuthentication(o =>
        // {
        //     
        // }).AddJwtBearer();
        // builder.Services
        //     .AddAuthentication()
        //     .AddGoogle(googleOptions =>
        //     {
        //         googleOptions.ClientId = gId;
        //         googleOptions.ClientSecret = gSecret;
        //     });
        //      
        
        builder.Services
            .SwaggerDocument();

        
        var app = builder.Build();
        app
            .UseAuthentication()
            .UseAuthorization()
            .UseFastEndpoints(
                 c => { c.Endpoints.Configurator = epd => epd.AllowAnonymous(); }
                ).UseSwaggerGen();

        app.Run();
    }
}
