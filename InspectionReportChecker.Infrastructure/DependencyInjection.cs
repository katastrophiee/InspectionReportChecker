using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace InspectionReportChecker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));
        return services;
    }
}
