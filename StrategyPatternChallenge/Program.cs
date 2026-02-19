using StrategyPatternChallenge.Strategies;
using System.Reflection.Metadata;

namespace StrategyPatternChallenge;

internal class Program
{
    private static void Main(string[] args)
    {
        UseSimpleSelector();

        UseFactory();

        Console.ReadKey();
    }

    private static void UseFactory()
    {
        // Step 1: Create an order with a total weight and a shipping method
        //var order = new Order(10, "UPS");
        // var order = new Order(10, "FEDEX");
         var order = new Order(10, "USPS");
        //var order = new Order(10, "DHL");

        // Step 2: Determine the appropriate shipping strategy based on the order's shipping method
        IShippingStrategy strategy = ShippingStrategyFactory.Create(order.ShippingMethod);

        // Step 3: Inject the selected strategy into the calculator (context)
        var calculator = new ShippingCalculator(strategy);

        // Step 4: Delegate the shipping cost calculation to the strategy
        var cost = calculator.CalculateShippingCost(order);

        // Step 5: Output the calculated shipping cost
        Console.WriteLine($"Shipping cost for {order.ShippingMethod}: {cost}");
    }

    private static void UseSimpleSelector()
    {
        // Step 1: Create an order with a total weight and a shipping method
        //var order = new Order(10, "UPS");
        // var order = new Order(10, "FEDEX");
        // var order = new Order(10, "USPS");
        var order = new Order(10, "DHL");

        // Step 2: Determine the appropriate shipping strategy based on the order's shipping method
        IShippingStrategy strategy;

        switch (order.ShippingMethod)
        {
            case "UPS":
                strategy = new UpsStrategy();
                break;
            case "FEDEX":
                strategy = new FedexStrategy();
                break;
            case "USPS":
                strategy = new UspsStrategy();
                break;
            case "DHL":
                strategy = new DhlStrategy();
                break;
            default:
                throw new InvalidOperationException("Unsupported shipping method");
        }

        // Step 3: Inject the selected strategy into the calculator (context)
        var calculator = new ShippingCalculator(strategy);

        // Step 4: Delegate the shipping cost calculation to the strategy
        var cost = calculator.CalculateShippingCost(order);

        // Step 5: Output the calculated shipping cost
        Console.WriteLine($"Shipping cost for {order.ShippingMethod}: {cost}");
    }
}