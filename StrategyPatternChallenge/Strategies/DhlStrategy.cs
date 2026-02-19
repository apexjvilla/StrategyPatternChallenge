namespace StrategyPatternChallenge.Strategies
{
    public class DhlStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.9;
        }
    }
}
