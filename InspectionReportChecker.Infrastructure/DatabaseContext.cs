using InspectionReportChecker.Domain.StoredProcedureResults;
using InspectionReportChecker.Infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace InspectionReportChecker.Infrastructure;

public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
{
    public DbSet<InspectionReport> InspectionReport { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InspectionReportEntityTypeConfig());
    }
}
