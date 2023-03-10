using DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Common;

namespace DesignPatterns.Core.Behavioral.Strategy.ShippingProviders.Providers;

public class InPostPachkomat : IShippingProvider
{
    public int CalculateCost(int distance)
    {
        return distance * 4;
    }
}