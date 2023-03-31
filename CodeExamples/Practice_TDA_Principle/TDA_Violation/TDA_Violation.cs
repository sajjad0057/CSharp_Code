namespace Practice_TDA_Principle.TDA_Violation;

public class TDA_Violation
{
    public void CalculatePrice(Vehicle vehicle, CostCalculaor costCalculator, int discount)
    {
        var netPrice = discount > 5 ? vehicle.TotalPrice = 5000 : vehicle.TotalPrice - 3000;

        if(netPrice > costCalculator.BasePrice)
        {
            costCalculator.ApplyAccessories();
        }
        else
        {
            //// Accessories cannot be provided
        }
    }
}


public class CostCalculaor
{
    public int BasePrice { get; set; }

    public void ApplyAccessories()
    {
        //// logical code
    }
}


public class Vehicle
{
    public int TotalPrice { get; set; }
}


/*
We check for the discount applicable on the vehicle. If it is greater than 5%, we subtract 5000 from the actual price else 3000, as a discount. We also have a net price price defined for the vehicle. After applying the discount, if the net price is more than this base price, we can further provide free accessories else we do not.

This type of code will have the following issues:

1. If we have the same type of logic in other areas of the application then changes in the logic 
   will require changes in all the locations.
 
2. The client code is now aware of the business logic to calculate the cost of the vehicle.
 
3. Some of the member functions/properties are unnecessarily exposed as public members to the client code.

*/