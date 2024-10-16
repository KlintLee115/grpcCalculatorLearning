using Grpc.Core;

namespace CalculationMicroservice.Services;

public class CalculationMicroserviceClass(ILogger<CalculationMicroserviceClass> logger) : Calculator.CalculatorBase 
{
    private readonly ILogger<CalculationMicroserviceClass> _logger = logger;

    public override Task<CalculationAns> Add(CalculationParams request, ServerCallContext context)
    {
        return Task.FromResult(new CalculationAns
        {
            Ans = request.Num1 + request.Num2 
        });
    }

    public override Task<CalculationAns> Subtract(CalculationParams request, ServerCallContext context)
    {
        return Task.FromResult(new CalculationAns
        {
            Ans = request.Num1 - request.Num2 
        });
    }

    public override Task<CalculationAns> Multiply(CalculationParams request, ServerCallContext context)
    {
        return Task.FromResult(new CalculationAns
        {
            Ans = request.Num1 * request.Num2 
        });
    }

    public override Task<CalculationAns> Divide(CalculationParams request, ServerCallContext context)
    {
        return Task.FromResult(new CalculationAns
        {
            Ans = request.Num1 / request.Num2 
        });
    }
}
