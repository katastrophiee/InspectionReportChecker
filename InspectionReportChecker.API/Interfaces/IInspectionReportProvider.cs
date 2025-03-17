using InspectionReportChecker.Domain.Models;

namespace InspectionReportChecker.Application.Interfaces;

public interface IInspectionReportProvider
{
    public Task<InspectionReport> GetInspectionReportAsync(int reportId);
}
