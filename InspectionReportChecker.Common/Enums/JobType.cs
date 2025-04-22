using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum JobType
{
    [Display(Name = "Request Quote")]
    RequestQuote = 0,

    [Display(Name = "Fixed Price")]
    FixedPrice = 1,

    [Display(Name = "Both")]
    Both = 2,

    [Display(Name = "Guaranteed Price")]
    GuaranteedPrice = 3,

    Unknown = 255
}
