namespace StrategyPatternChallenge
{
    public class Order
    {
        public Order() { }

        public Order(double totalWeight, string shippingMethod)
        {
            TotalWeight = totalWeight;
            ShippingMethod = shippingMethod;
        }

        public double TotalWeight { get; set; }
        public string ShippingMethod { get; set; } // e.g., "UPS", "FedEx"
    }
}