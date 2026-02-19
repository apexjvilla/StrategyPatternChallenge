using StrategyPatternChallenge.Strategies;

namespace StrategyPatternChallenge
{
    public static class ShippingStrategyFactory
    {
        public static IShippingStrategy Create(string shippingMethod)
        {
            switch (shippingMethod)
            {
                case "UPS":
                    return new UpsStrategy();
                case "FEDEX":
                    return new FedexStrategy();
                case "USPS":
                    return new UspsStrategy();
                case "DHL":
                    return new DhlStrategy();
                default:
                    throw new InvalidOperationException("Unsupported shipping method");
            }
        }
    }
}
