namespace StrategyPatternChallenge.Strategies
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(Order order);
    }
}
