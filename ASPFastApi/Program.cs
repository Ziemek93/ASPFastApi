using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var conntectionString = builder.Configuration.GetConnectionString("BlogConnection");
builder.Services.AddScoped<FastApi.Context.AppContext>();

builder.Services
    .AddFastEndpoints()
    .SwaggerDocument();
builder.Services.AddDbContext<FastApi.Context.AppContext>(options => options.UseSqlServer(conntectionString));

var app = builder.Build();

app.Run();
