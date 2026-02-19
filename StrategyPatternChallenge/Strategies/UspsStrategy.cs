namespace StrategyPatternChallenge.Strategies
{
    public class UspsStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.4;
        }
    }
}
