using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using Microsoft.AspNetCore.Components;

namespace InspectionReportChecker.WebUI.Server.Components.Pages;

public partial class ViewJob
{
    [Inject]
    public IJobsProvider _inspectionReportProvider { get; set; }

    [Parameter]
    public int JobId { get; set; }

    public bool IsLoading { get; set; } = false;

    public Job? Job { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;

        var job = await _inspectionReportProvider.GetJobsById(JobId);

        if (job is null)
        {
            //something errory here idk
            IsLoading = false;
            return;
        }

        //fix later
        Job = job.FirstOrDefault();   
        IsLoading = false;
    }
}
