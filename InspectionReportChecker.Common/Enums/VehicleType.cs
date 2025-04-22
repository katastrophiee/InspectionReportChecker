using System.ComponentModel.DataAnnotations;

namespace InspectionReportChecker.Common.Enums;

public enum VehicleType
{
    Cars = 0,

    [Display(Name = "Light Commercial")]
    LightCommercial = 1,

    HGV = 2,

    Unknown = 255
}

