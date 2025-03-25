using InspectionReportChecker.Application.Interfaces;
using InspectionReportChecker.Domain.Models;
using InspectionReportChecker.WebUI.Server.Models;
using Microsoft.AspNetCore.Components;

namespace InspectionReportChecker.WebUI.Server.Components.Pages;

public partial class Home
{
    [Inject]
    public IInspectionReportProvider _inspectionReportProvider {  get; set; }

    [Parameter]
    public SearchModel<InspectionReport> SearchModel { get; set; } = new();

    public bool IsLoading { get; set; } = false;

    public bool HasSeached { get; set; } = false;

    // keeping bc i'll probs need this in future
    //protected override async Task OnInitializedAsync()
    //{
    //    var lol = true;
    //}

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
            SearchModel.Results = await _inspectionReportProvider.GetInspectionReportsById(reportId) ?? [];
        }
        else
        {
            SearchModel.Results = [];
        }

        IsLoading = false;
    }
}
