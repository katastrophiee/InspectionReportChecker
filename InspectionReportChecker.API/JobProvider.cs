using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using InspectionReportChecker.Infrastructure;
using Microsoft.Extensions.Logging;

namespace InspectionReportChecker.Application;

public class JobProvider(ILogger<JobProvider> logger, IJobsRepository jobsRepository) : IJobsProvider
{
    private readonly ILogger<JobProvider> _logger = logger;
    private readonly IJobsRepository _jobsRepository = jobsRepository;

    public async Task<List<Job>> GetJobsById(int jobId)
    {
        try
        {
            var jobs = await _jobsRepository.GetJobsById(jobId);

            return jobs;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unknown error occurred while searching reports with report ID: {reportId}", jobId);

            // change to log + return error
            return [];
        }
    }

  //  public async Task<Job?> GetJob(int jobId)
  //  {
		//try
		//{
		//	if (jobId == 1)
  //          {

		//        return new()
		//        {
		//	        Id = 1,
  //                  Status = 2, //change to enum from work code for job statuses
  //                  Vehicles =
  //                  [
  //                      new() { Id = 1, VRM = "fuck you ben", POCUploaded = true, PODUploaded = false  }
  //                  ]
		//        };
  //          }

  //          return null;
		//}
		//catch (Exception ex)
		//{
		//	_logger.LogError(ex, "An unknown error occured when retrieving report {reportId}", jobId);
            
		//	//CHANGE TO HANDLE ERRORS
		//	return null;
  //      }
  //  }

  //  public async Task<bool> RetryJsonProcessing(string inspectionReportName)
  //  {
  //      // TO DO
  //      return true;
  //  }
}
