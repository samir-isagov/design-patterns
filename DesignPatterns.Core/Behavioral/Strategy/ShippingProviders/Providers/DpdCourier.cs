using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Providers;

public class DpdCourier : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 2;
    }
}