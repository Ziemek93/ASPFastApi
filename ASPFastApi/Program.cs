using ASPFastApi.Middleware;
using ASPFastApi.Middleware.Identity;
using ASPFastApi.Repositories.Articles;
using ASPFastApi.Services.ArticleService;
using FastApi.Context;
using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public partial class Program // Now public for easier accessibility
{
    static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
        builder.Services.AddScoped<ApplicationContext>();
        builder.Services.AddScoped<IAuthServiceOld, AuthServiceOld>();
        builder.Services.AddScoped<IArticleService, ArticleService>();
        builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

        ///Microsoft.EntityFrameworkCore
        builder.Services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseNpgsql(conntectionString);
        });
        //builder.Services.AddDbContext<FastApi.Context.ApplicationContext>(options => options.UseSqlServer(conntectionString));
        var apiKey = builder.Configuration.GetSection("Auth").GetSection("ApiKey").Value;
        var gId = builder.Configuration.GetSection("GoogleAuth").GetSection("id").Value;
        var gSecret = builder.Configuration.GetSection("GoogleAuth").GetSection("secret").Value;

        builder.Services
            //.AddAuthenticationJwtBearer(
            //s =>
            //{
            //    s.SigningKey = apiKey;
            //}
            //)

            //.AddAuthorization()
            .AddFastEndpoints();

        builder.Services.AddIdentityApiEndpoints<IdentityUser>(
            opt =>
            {
                opt.Password.RequiredLength = 6;
            }
            )
            .AddEntityFrameworkStores<ApplicationContext>();

        builder.Services.AddAuthentication(o =>
        {
            o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(o =>
        {
            o.TokenValidationParameters = new TokenValidationParameters()
            {
                //ValidateActor = true,
                //ValidateIssuer = true,
                //ValidateAudience = true,
                //RequireExpirationTime = true,
                //ValidIssuer = builder.Configuration.GetSection("Jwt:Issuer").Value,
                //ValidAudience = builder.Configuration.GetSection("Jwt:Audience").Value,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(apiKey))
            }
            ;
        });
        builder.Services.AddAuthenticationJwtBearer(x => x.SigningKey = apiKey);

        //.AddDefaultTokenProviders();
        builder.Services.AddAuthorization(o =>
        {
            o.AddPolicy(IdentityData.AdminUserPolicyName, p =>
            p.RequireClaim(IdentityData.AdminUserclaimName, "true"));
        });

        //builder.Services.AddIdentityCore<IdentityUser>().add
        builder.Services.SwaggerDocument();

        var app = builder.Build();
        //app.MapIdentityApi<IdentityUser>();
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwaggerGen();
        //    app.UseSwaggerUi();
        //}
        //app.UseHttpsRedirection();
        app.MapGroup("/identity").MapIdentityApi<IdentityUser>();

        app
            .UseAuthentication()
            .UseAuthorization()
            .UseFastEndpoints(
                //c => { c.Endpoints.Configurator = epd => epd.AllowAnonymous(); }
                ).UseSwaggerGen();



        app.Run();
    }
}
