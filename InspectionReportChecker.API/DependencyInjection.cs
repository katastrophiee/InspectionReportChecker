using Microsoft.Extensions.DependencyInjection;

namespace InspectionReportChecker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //add dependencies n shit here
        //e.g.
        //services.AddScoped<IRepository, Repository>();

        return services;
    }
}
