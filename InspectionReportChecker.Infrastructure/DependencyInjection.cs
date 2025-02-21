using Microsoft.Extensions.DependencyInjection;

namespace InspectionReportChecker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //add dependencies n shit here
        //e.g. adding ef framework and dependencies
        return services;
    }
}
