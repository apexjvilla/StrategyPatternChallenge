namespace StrategyPatternChallenge.Strategies
{
    public class UpsStrategy : IShippingStrategy
    {
        public string ShippingMethod => "UPS";

        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.5;
        }
    }
}
