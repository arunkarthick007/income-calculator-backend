using System.ComponentModel.DataAnnotations;

namespace Income_CalculatorAPI.DTOs;

public record class InputDTO
(
    int Id,
    [Required] string Name,
    [Required][EmailAddress] string EmailId,
    [Required][Range(1, int.MaxValue)] int Cash_Week,
    [Required][Range(1, 100)] int Advance_percentage,
    [Required][Range(1, 100)] int Commission_Rate,
    [Required][Range(1, 7)] int Working_Days
);
