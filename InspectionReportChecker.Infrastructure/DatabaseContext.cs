using InspectionReportChecker.Domain.Models;
using InspectionReportChecker.Infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace InspectionReportChecker.Infrastructure;

public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
{
    public DbSet<Job> Job { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InspectionReportEntityTypeConfig());
    }
}
