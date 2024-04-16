using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

using System;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

public class Program // Now public for easier accessibility
{
    static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
        builder.Services.AddScoped<ApplicationContext>();

      
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(conntectionString));
        //builder.Services.AddDbContext<FastApi.Context.ApplicationContext>(options => options.UseSqlServer(conntectionString));
        builder.Services
            .AddAuthenticationJwtBearer(s =>
            {
                s.SigningKey = "testjwttestjwttestjwttestjwttestjwttestjwttestjwttestjwt";
            }) 
            .AddAuthorization()
            .AddFastEndpoints(); 
        
        builder.Services
            .SwaggerDocument();

        
        var app = builder.Build();
        app
            .UseAuthentication()
            .UseAuthorization()
            .UseFastEndpoints(
                // c => { c.Endpoints.Configurator = epd => epd.AllowAnonymous(); }
                ).UseSwaggerGen();

        app.Run();
    }
}
