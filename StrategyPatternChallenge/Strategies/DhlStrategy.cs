namespace StrategyPatternChallenge.Strategies
{
    public class DhlStrategy : IShippingStrategy
    {
        public string ShippingMethod => "DHL";

        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.9;
        }
    }
}
