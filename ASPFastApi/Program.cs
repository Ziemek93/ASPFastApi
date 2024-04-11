using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

using System;
using Microsoft.AspNetCore.Authentication;

public class Program // Now public for easier accessibility
{
    static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
        builder.Services.AddScoped<ApplicationContext>();

        builder.Services
            .AddFastEndpoints();
        builder.Services
            .SwaggerDocument();
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(conntectionString));
        //builder.Services.AddDbContext<FastApi.Context.ApplicationContext>(options => options.UseSqlServer(conntectionString));
        //"BlogConnection": "Server=DESKTOP-VA6351T\\SQLEXPRESS;Database=Blog;User id=TestUser;Password=qwerty;Encrypt=Optional"

        var app = builder.Build();
        app.UseFastEndpoints(c => {
            // everything is anonymous for this sample test
            c.Endpoints.Configurator = epd => epd.AllowAnonymous();
        }).UseSwaggerGen();

        app.Run();
    }
}