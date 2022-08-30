using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Unify.EFTest.Data;

public static class DataRegistry
{
    private const string SqlServerConfigurationKey = "SqlServer";

    /// <summary>
    /// Service collection method to add database context to startup.
    /// </summary>
    public static void AddDataContext(this IServiceCollection services)
    {
        // Data config 
        services
            .AddOptions<DataConfig>()
            .Configure<IConfiguration>((options, config) => config.Bind(SqlServerConfigurationKey, options));

        ServiceProvider currentServices = services.BuildServiceProvider();
        var postgresConfig = currentServices.GetRequiredService<IOptions<DataConfig>>();

        // Assign the connection string from config to DB Context class
        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(postgresConfig.Value.ConnectionString));
    }
}