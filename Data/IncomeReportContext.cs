using Income_CalculatorAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Income_CalculatorAPI.Data;

public class IncomeReportContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public IncomeReportContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }
    public DbSet<IncomeReport> IncomeReport => Set<IncomeReport>();
}
