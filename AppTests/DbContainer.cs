using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using FastApi.Context;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppTests;

public class DbContainer
{

    private const string Database = "master";
    private const string Username = "sa";
    private const string Password = "$trongPassword";
    private const ushort MsSqlPort = 1433;

    // private readonly AppFixture<Program> factory;


    // private WebApplicationFactory<Program> _factory;
    private WebApplicationFactory<Program> _factory;
    private IContainer _container;
    public async Task OneTimeSetUp()
    {
        // Set up Testcontainers SQL Server container
        _container = new ContainerBuilder()
            .WithImage("mcr.microsoft.com/mssql/server:2022-latest")
            .WithPortBinding(MsSqlPort, true)
            .WithEnvironment("ACCEPT_EULA", "Y")
            .WithEnvironment("SQLCMDUSER", Username)
            .WithEnvironment("SQLCMDPASSWORD", Password)
            .WithEnvironment("MSSQL_SA_PASSWORD", Password)
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(MsSqlPort))
            .Build();

        //Start Container
        await _container.StartAsync();

        var host = _container.Hostname;
        var port = _container.GetMappedPublicPort(MsSqlPort);

        // Replace connection string in DbContext
        var connectionString =
            $"Server={host},{port};Database={Database};User Id={Username};Password={Password};TrustServerCertificate=True";


        _factory = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddDbContext<ApplicationContext>(options =>
                        options.UseSqlServer(connectionString));
                });
            });
        using var scope = _factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        dbContext.Database.Migrate();

    }

    public async Task OneTimeTearDown()
    {
        await _container.StopAsync();
        await _container.DisposeAsync();
        _factory.Dispose();
    }

    public HttpClient MakeQuery()
    {
        var client = _factory.CreateClient();

        return client;
        // var ResponsResult = await client.GetAsync("/api/Resident/GetAllResidents");
        //
        // ResponsResult.EnsureSuccessStatusCode();
        // var content = await ResponsResult.Content.ReadAsStringAsync();
        // var allresidentsResponse = JsonSerializer.Deserialize<>(content);
        //
        // allresidentsResponse.Should().NotBeNull();
        // allresidentsResponse.residents.Should().NotBeNull();
        // allresidentsResponse.residents.Should().BeEmpty();
    }
}