using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum JobMovementType
{
    [Display(Name = "Internal Transfer")]
    InternalTransfer = 0,

    [Display(Name = "Dealer Transfer")]
    DealerTransfer = 1,

    [Display(Name = "Fleet Delivery")]
    FleetDelivery = 2,

    [Display(Name = "Retail Delivery")]
    RetailDelivery = 3,

    [Display(Name = "Premium Fleet")]
    PremiumFleet = 4,

    [Display(Name = "Premium Retail")]
    PremiumRetail = 5,

    [Display(Name = "Not Available")]
    NotAvailable = 255
}