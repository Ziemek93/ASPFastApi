using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

using System;

public class Program // Now public for easier accessibility
{
    static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
        builder.Services.AddScoped<ApplicationContext>();

        builder.Services
            .AddFastEndpoints()
            .SwaggerDocument();
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(conntectionString));
        //builder.Services.AddDbContext<FastApi.Context.ApplicationContext>(options => options.UseSqlServer(conntectionString));

        var app = builder.Build();
        app.UseFastEndpoints(c => {
            // everything is anonymous for this sample test
            c.Endpoints.Configurator = epd => epd.AllowAnonymous();
        }).UseSwaggerGen();

        app.Run();
    }
}