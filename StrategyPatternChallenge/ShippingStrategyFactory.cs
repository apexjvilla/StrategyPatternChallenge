using StrategyPatternChallenge.Strategies;

namespace StrategyPatternChallenge
{
    public static class ShippingStrategyFactory
    {
        private static readonly List<IShippingStrategy> strategies =
        [
            new UpsStrategy(),
            new FedexStrategy(),
            new UspsStrategy(),
            new DhlStrategy()
        ];

        public static IShippingStrategy Create(string shippingMethod)
        {
            var strategy = strategies
                .FirstOrDefault(x => x.ShippingMethod == shippingMethod);

            if (strategy == null)
                throw new ArgumentException($"No strategy found for {shippingMethod}");

            return strategy;
        }
    }
}
