using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using Microsoft.Extensions.Logging;

namespace InspectionReportChecker.Application;

public class InspectionReportProvider(ILogger<InspectionReportProvider> logger) : IInspectionReportProvider
{
    private readonly ILogger<InspectionReportProvider> _logger = logger;

    public async Task<List<InspectionReport>> GetInspectionReportsById(int reportId)
    {
        try
        {
            var fakeReports = new List<InspectionReport>
            {
                new() { Id = 1 },
                new() { Id = 11 },
                new() { Id = 12 },
                new() { Id = 2 },
                new() { Id = 3 }
            };

            // delay to pretend it's real for now so i can look at my cute little loading bar
            await Task.Delay(500);

            var reports = fakeReports
                .Where(report => report.Id.ToString().Contains(reportId.ToString()))
                .OrderBy(report => report.Id)
                .ToList();

            return reports;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unknown error occurred while searching reports with report ID: {reportId}", reportId);

            // change to log + return error
            return [];
        }
    }

    public async Task<InspectionReport> GetInspectionReport(int reportId)
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
