using Microsoft.Extensions.DependencyInjection;
using Unify.EFTest.Service.Departments;

namespace Unify.EFTest.Service;

public static class ServiceRegistry
{
    /// <summary>
    /// Service collection method to add service to startup.
    /// </summary>
    public static void AddServices(this IServiceCollection services)
    {
        // Data config 
        services.AddScoped<IDepartmentService, DepartmentService>();
    }
}