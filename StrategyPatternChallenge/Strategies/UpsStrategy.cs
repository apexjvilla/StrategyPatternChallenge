namespace StrategyPatternChallenge.Strategies
{
    public class UpsStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.5;
        }
    }
}
