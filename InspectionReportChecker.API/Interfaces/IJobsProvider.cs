using InspectionReportChecker.Domain.Models;

namespace InspectionReportChecker.Application.Interfaces;

public interface IJobsProvider
{
    Task<List<Job>> GetJobsById(int jobId);
}
