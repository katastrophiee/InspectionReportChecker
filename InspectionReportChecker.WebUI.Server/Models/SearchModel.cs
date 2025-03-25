using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.WebUI.Server.Models;

public class SearchModel<T>
{
    
    [Required(ErrorMessage = "The search term cannot be empty")]
    public string SearchTerm { get; set; } = string.Empty;
    public List<T> Results { get; set; }
}
