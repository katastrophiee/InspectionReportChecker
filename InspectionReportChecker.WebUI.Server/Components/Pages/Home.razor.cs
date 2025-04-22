using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using InspectionReportChecker.WebUI.Server.Models;
using Microsoft.AspNetCore.Components;

namespace InspectionReportChecker.WebUI.Server.Components.Pages;

public partial class Home
{
    [Inject]
    public IJobsProvider _inspectionReportProvider {  get; set; }

    [Parameter]
    public SearchModel<Job> SearchModel { get; set; } = new();

    public bool IsLoading { get; set; } = false;

    public bool HasSeached { get; set; } = false;

    private async Task GetReports()
    {
        IsLoading = true;
        HasSeached = true;

        if (string.IsNullOrEmpty(SearchModel.SearchTerm))
        {
            //return custom error here
            return;
        }

        if (int.TryParse(SearchModel.SearchTerm, out int reportId))
        {
            SearchModel.Results = await _inspectionReportProvider.GetJobsById(reportId) ?? [];
        }
        else
        {
            SearchModel.Results = [];
        }

        IsLoading = false;
    }
}
