using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InspectionReportChecker.Domain.StoredProcedureResults;

namespace InspectionReportChecker.Infrastructure.EntityTypeConfiguration;

public class InspectionReportEntityTypeConfig : IEntityTypeConfiguration<InspectionReport>
{
    public void Configure(EntityTypeBuilder<InspectionReport> builder)
    {
        builder.HasKey(e => e.Id);
    }
}
