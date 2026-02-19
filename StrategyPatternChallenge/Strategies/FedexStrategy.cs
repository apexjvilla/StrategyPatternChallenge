namespace StrategyPatternChallenge.Strategies
{
    public class FedexStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.7;
        }
    }
}
