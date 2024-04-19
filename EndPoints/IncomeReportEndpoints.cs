using Income_CalculatorAPI.Data;
using Income_CalculatorAPI.Entities;
using Income_CalculatorAPI.Mapping;

namespace Income_CalculatorAPI.DTOs;

public static class IncomeReportEndpoints
{
    public static RouteGroupBuilder MapIncomeReportEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("incomereport").WithParameterValidation();

        group.MapGet("/", (IncomeReportContext dbContext) =>
           {
               return Results.NoContent();
           });

        group.MapPost("/", async (InputDTO newInput, IncomeReportContext dbContext) =>
        {
            IncomeReport incomeReport = newInput.ToEntity();
            dbContext.IncomeReport.Add(incomeReport);
            await dbContext.SaveChangesAsync();

            return Results.Json(incomeReport.Id);
        });

        return group;
    }
}
