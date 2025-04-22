using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum JobStatus
{
    Cancelled = 0,
    Aborted = 6,

    Draft = 7,

    [Display(Name = "Pending")]
    PendingQuotes = 1,

    [Display(Name = "Booked")]
    BookedJob = 25,

    [Display(Name = "Active")]
    ActiveJob = 3,

    [Display(Name = "Completed")]
    CompletedJob = 4,

    [Display(Name = "Admin Removed / Failed")]
    AdminRemoved_Or_Failed = 5,

    Expired = 100
}