using InspectionReportChecker.Domain.Models;

namespace InspectionReportChecker.Application.Interfaces;

public interface IInspectionReportProvider
{
    Task<List<InspectionReport>> GetInspectionReportsById(int reportId);

    Task<InspectionReport> GetInspectionReport(int reportId);
}
