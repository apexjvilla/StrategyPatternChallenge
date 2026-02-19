namespace StrategyPatternChallenge.Strategies
{
    public class UspsStrategy : IShippingStrategy
    {
            public string ShippingMethod => "USPS";

        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.4;
        }
    }
}
