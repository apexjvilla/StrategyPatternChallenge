using StrategyPatternChallenge.Strategies;

namespace StrategyPatternChallenge
{
    public class ShippingCalculator
    {
        private readonly IShippingStrategy shippingStrategy;

        public ShippingCalculator(IShippingStrategy shippingStrategy)
        {
            this.shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {   
            return shippingStrategy.CalculateShippingCost(order);
        }
    }
}
