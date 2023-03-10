using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Providers;

public class UPS : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 7;
    }
}