# Strategy Pattern Refactor
---

## Problem
You are given a tightly coupled ShippingCalculator class. The method CalculateShippingCost uses a switch statement to determine the shipping cost based on the ShippingMethod (e.g., "UPS", "FedEx", "USPS").

Your task is to refactor this class to use the Strategy Pattern. This will make the system Open/Closed (open for extension, closed for modification), allowing new shipping methods to be added without modifying the ShippingCalculator class.

## Starter Code:
```C#
 
 
public class Order

{

  public double TotalWeight { get; set; }

  public string ShippingMethod { get; set; } // e.g., "UPS", "FedEx"

}



public class ShippingCalculator

{

  // BAD: Violates Open/Closed Principle

  public double CalculateShippingCost(Order order)

  {

      switch (order.ShippingMethod)

      {

          case "UPS":

              return order.TotalWeight * 0.5;

          case "FedEx":

              return order.TotalWeight * 0.7;

          case "USPS":

              return order.TotalWeight * 0.4;

          default:

              throw new ArgumentException("Invalid shipping method");

      }

  }

} 
```