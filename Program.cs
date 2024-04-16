using System.Text.Json.Serialization;
using Income_CalculatorAPI.Data;
using Income_CalculatorAPI.DTOs;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddDbContext<IncomeReportContext>();
services.AddCors();
var app = builder.Build();

{
    // global cors policy
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    // global error handler

    app.MapIncomeReportEndpoints();
}
app.MigrateDb();

app.Run();
