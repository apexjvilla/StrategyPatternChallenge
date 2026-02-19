namespace StrategyPatternChallenge.Strategies
{
    public class FedexStrategy : IShippingStrategy
    {
        public string ShippingMethod => "FEDEX";

        public double CalculateShippingCost(Order order)
        {
            return order.TotalWeight * 0.7;
        }
    }
}
