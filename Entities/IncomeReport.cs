namespace Income_CalculatorAPI.Entities;

public class IncomeReport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public required string? EmailId { get; set; }
    public required int CashPerWeek { get; set; }
    public required int AdvancePercentage { get; set; }
    public required int CommissionPercentage { get; set; }
    public required int WorkingDays { get; set; }
}
