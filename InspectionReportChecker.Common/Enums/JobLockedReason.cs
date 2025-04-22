using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum JobLockedReason
{
    [Display(Name = "Payment in progress")]
    PaymentInProgress = 0,

    [Display(Name = "Locked for feedback")]
    LockedForFeedback = 1,

    [Display(Name = "Job closed")]
    JobClosed = 2,

    [Display(Name = "Unlocked")]
    NotLocked = 254,

    [Display(Name = "Unknown")]
    Unknown = 255,
}

