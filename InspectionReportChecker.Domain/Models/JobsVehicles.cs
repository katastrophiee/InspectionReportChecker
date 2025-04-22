using InspectionReportChecker.Common.Enums;

namespace InspectionReportChecker.Domain.Models;

public class JobsVehicles
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public int? JobId { get; set; }
    public string Vrm { get; set; }
    public string Vin { get; set; }
    public VehicleType? VehicleType { get; set; }
    public string VehicleMake { get; set; }
    public string VehicleModel { get; set; }
    public string VehicleColour { get; set; }
    public int? VehicleYear { get; set; }
    public int? VehicleLength { get; set; }
    public int? VehicleWidth { get; set; }
    public int? VehicleHeight { get; set; }
    public int? VehicleWeight { get; set; }
    public bool IsReturnVehicle { get; set; }
    public bool IsSegmentVehicle { get; set; }
    public int? SegmentIndex { get; set; }
    public bool? VehicleIsNew { get; set; }
    public decimal? VehicleValue { get; set; }
    public int? DriverId { get; set; }
    public bool? IsAborted { get; set; }
    public DateTime? AbortDate { get; set; }
    public string AbortReason { get; set; }
    public string AbortName { get; set; }
    public string AbortSignature { get; set; }
    public virtual Job Job { get; set; }
    public FuelType? FuelTypeID { get; set; }
    public byte BodyTypeId { get; set; }
}