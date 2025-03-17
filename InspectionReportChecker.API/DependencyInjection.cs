using InspectionReportChecker.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InspectionReportChecker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IInspectionReportProvider, InspectionReportProvider>();

        return services;
    }
}
