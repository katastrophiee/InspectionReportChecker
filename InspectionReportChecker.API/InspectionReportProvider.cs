using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using Microsoft.Extensions.Logging;

namespace InspectionReportChecker.Application;

public class InspectionReportProvider(ILogger<InspectionReportProvider> logger) : IInspectionReportProvider
{
    private readonly ILogger<InspectionReportProvider> _logger = logger;

    public async Task<InspectionReport> GetInspectionReportAsync(int reportId)
    {
		try
		{
			//TEST - DELETE LATER
			return new()
			{
				Id = 1
			};
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "An unknown error occured when retrieving report {reportId}", reportId);
            
			//CHANGE TO HANDLE ERRORS
			return null;
        }
    }
}
