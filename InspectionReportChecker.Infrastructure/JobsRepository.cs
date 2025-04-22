using InspectionReportChecker.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InspectionReportChecker.Infrastructure;

class JobsRepository(DBContext dBContext) : IJobsRepository
{
    private readonly DBContext _dbContext = dBContext;

    public async Task<List<Job>> GetJobsById(int jobId)
    {
		try
		{
			var jobs = await _dbContext.Job.Where(j => j.Id.ToString().Contains(jobId.ToString())).ToListAsync();

			return jobs ?? [];
		}
		catch (Exception ex)
		{

			throw;
		}
    }
}
