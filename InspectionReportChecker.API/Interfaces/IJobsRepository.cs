using InspectionReportChecker.Domain.Models;

namespace InspectionReportChecker.Infrastructure;

public interface IJobsRepository
{
    Task<List<Job>> GetJobsById(int jobId);
}
