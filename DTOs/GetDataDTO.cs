namespace Income_CalculatorAPI.DTOs;

public record class GetDataDTO
(
    string Name,
    string EmailId,
    int Cash_Week,
    int Advance_percentage,
    int Commission_Rate,
    int Working_Days
);
