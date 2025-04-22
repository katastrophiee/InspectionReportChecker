using InspectionReportChecker.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace InspectionReportChecker.Domain.Models;

public class Job
{
    public int Id { get; set; }
    public byte[] Timestamp { get; set; }
    public int? AdminUserId { get; set; }
    public int? RequestingMemberId { get; set; }
    public bool RequestingMemberHasSeen { get; set; }
    public int? SupplyingMemberId { get; set; }
    public bool SupplyingMemberHasSeen { get; set; }
    public JobStatus? JobStatus { get; set; }
    public DateTime RequestDate { get; set; }
    public JobKind? JobKind { get; set; }
    public int? NoOfVehicles { get; set; }
    public int? NoOfReturnVehicles { get; set; }
    public double? DistanceMiles { get; set; }
    public string CollectionContact { get; set; }
    public string CollectionPhone { get; set; }
    public string CollectionCompany { get; set; }
    public string CollectionAddress { get; set; }
    public string CollectionTown { get; set; }
    public string CollectionPostCode { get; set; }
    public double? CollectionLatitude { get; set; }
    public double? CollectionLongitude { get; set; }
    public string DeliveryContact { get; set; }
    public string DeliveryPhone { get; set; }
    public string DeliveryCompany { get; set; }
    public string DeliveryAddress { get; set; }
    public string DeliveryTown { get; set; }
    public string DeliveryPostCode { get; set; }
    public double? DeliveryLatitude { get; set; }
    public double? DeliveryLongitude { get; set; }
    public DateTime? CollectionDate { get; set; }
    public JobTime? CollectionTime { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public JobTime? DeliveryTime { get; set; }
    public ServiceType? ServiceType { get; set; }
    public bool? DrivenValidMot { get; set; }
    public bool? TransportedDriveOnto { get; set; }
    public JobType? JobType { get; set; }
    public decimal? DFixedPriceMin { get; set; }
    public bool? Dvat { get; set; }
    public bool? DfuelCost { get; set; }
    public decimal? TFixedPriceMin { get; set; }
    public bool? Tvat { get; set; }
    public string AdditionalNotes { get; set; }
    public string AdminNotes { get; set; }
    public int? PartnerId { get; set; }
    public string PartnerJid { get; set; }
    public string PartnerCid { get; set; }
    public long? DurationSeconds { get; set; }
    public bool? UseExactCollectionDateAndTime { get; set; }
    public bool? UseExactDeliveryDateAndTime { get; set; }
    public JobOfferedTo? JobOfferedTo { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
    public decimal? DestimatedFuelCost { get; set; }
    public string Reference { get; set; }
    public bool? DrivenFuelRequired { get; set; }
    public decimal? DFixedPriceMax { get; set; }
    public decimal? TFixedPriceMax { get; set; }
    public string PromoCode { get; set; }
    public decimal? DguaranteedPrice { get; set; }
    public decimal? TguaranteedPrice { get; set; }
    public JobMovementType? JobMovementType { get; set; }
    public bool IgnoreFavourites { get; set; }
    public DateTime? LockedDate { get; set; }
    public JobLockedReason LockedReason { get; set; }
    public string RoutePolyline { get; set; }
    public bool? TransportedEnclosed { get; set; }
    //public virtual ICollection<JobsSelectedSuppliers> JobsSelectedSuppliers { get; set; }
    //public virtual ICollection<JobsSegments> JobsSegments { get; set; }
    public virtual ICollection<JobsVehicles> JobsVehicles { get; set; }
    //public virtual ICollection<JobsPictures> JobsPictures { get; set; }
    //public virtual ICollection<JobsShippingNotes> JobsShippingNotes { get; set; }
    //public virtual IEnumerable<Quotes> Quotes { get; set; }
    //public virtual ICollection<JobsProofsOfCollection> JobsProofsOfCollection { get; set; }
    //public virtual ICollection<JobsProofsOfDelivery> JobsProofsOfDelivery { get; set; }

    //public virtual ICollection<JobsTracking> JobsTracking { get; set; }

    //public virtual ICollection<Feedback> Feedback { get; set; }

    [NotMapped]
    public int? Index { get; set; }

    [NotMapped]
    public int? JobId { get; set; }
 
}
