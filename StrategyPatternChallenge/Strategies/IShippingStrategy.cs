namespace StrategyPatternChallenge.Strategies
{
    public interface IShippingStrategy
    {
        string ShippingMethod { get; }
        double CalculateShippingCost(Order order);
    }
}
