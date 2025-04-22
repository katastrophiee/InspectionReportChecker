using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum JobOfferedTo
{
    [Display(Name = "Whole Network")]
    WholeNetwork = 0,

    [Display(Name = "5 Star Companies")]
    FiveStarCompanies = 1,

    [Display(Name = "Top Rated")]
    TopRated = 2,

    Favourites = 3,

    [Display(Name = "Selected Suppliers")]
    SelectedSuppliers = 4,

    [Display(Name = "MoDel Suppliers")]
    ModelSuppliers = 5,

    Unknown = 255
}
