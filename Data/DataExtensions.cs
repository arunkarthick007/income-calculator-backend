using Microsoft.EntityFrameworkCore;

namespace Income_CalculatorAPI.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<IncomeReportContext>();
        dbContext.Database.Migrate();
    }

}
