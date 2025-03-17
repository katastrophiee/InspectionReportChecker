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
    public HomeModel HomeModel { get; set; }

    public InspectionReport Report { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Report = await GetReport();
    }

    private async Task<InspectionReport> GetReport()
    {
        return await _inspectionReportProvider.GetInspectionReportAsync(1);
    }
}
