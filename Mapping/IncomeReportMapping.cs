using Income_CalculatorAPI.DTOs;
using Income_CalculatorAPI.Entities;

namespace Income_CalculatorAPI.Mapping;

public static class IncomeReportMapping
{
    public static IncomeReport ToEntity(this InputDTO newInput)
    {
        return new IncomeReport()
        {
            Name = newInput.Name,
            EmailId = newInput.EmailId,
            CashPerWeek = newInput.Cash_Week,
            AdvancePercentage = newInput.Advance_percentage,
            CommissionPercentage = newInput.Commission_Rate,
            WorkingDays = newInput.Working_Days
        };
    }

    public static InputDTO ToDto(this IncomeReport incomeReport)
    {
        return new
        (
            incomeReport.Id,
            incomeReport.Name!,
            incomeReport.EmailId!,
            incomeReport.CashPerWeek,
            incomeReport.AdvancePercentage,
            incomeReport.CommissionPercentage,
            incomeReport.WorkingDays
        );
    }
}
