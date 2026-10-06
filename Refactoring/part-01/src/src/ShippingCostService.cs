
namespace src;

public class ShippingCostService
{
    public ShippingCostService(ICarrier carrier)
    {
        _carrier = carrier;
    }

    private readonly ICarrier _carrier;

    public decimal CalculateCost(decimal weightKg) 
        => _carrier.Calculate(weightKg);
}


public interface ICarrier
{
    decimal Calculate(decimal weightKg);
}


public class Aramex : ICarrier
{
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}



public class FedEx : ICarrier
{
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}



public class DHL : ICarrier
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}


public class Bosta : ICarrier
{
    public decimal Calculate(decimal weightKg) => weightKg * 21m;
}