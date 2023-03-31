
/*
use the Tell, Don't Ask principle. So we change our code to shift the entire logic into the CostCalculator
class and pass the required data to it. It calculates the net price and based on results, it decides whether
or not it needs to make a further call to the ApplyAccessories() method. Our code now changes to:
*/

namespace Practice_TDA_Principle.TDA_Followed;

public class TDA_Followed
{
    public void CalculatePrice(Vehicle vehicle, CostCalculator costCalculator, Int32 discount)
    {
        costCalculator.NetCalculation(vehicle, discount);
    }
}


public class CostCalculator
{
    public int BasePrice { get; set; }
    public void NetCalculation(Vehicle vehicle, int discount)
    {
        var netPrice = discount > 5 ? vehicle.TotalPrice - 10000 : vehicle.TotalPrice - 20000;

        if(netPrice > this.BasePrice)
        {
            this.ApplyAccessories();
        }
        else
        {
            //// logical code
        }
    }


    private void ApplyAccessories()
    {
        //// logical code 
    }
}


public class Vehicle
{
    public int TotalPrice { get; set; }
}




/*
So in this case, the entire calculation logic, along with the logic to add accessories,
is inside the CostCalculator class. We simply provide the required data as input to this class.
Further, the ApplyAccessories method is now converted into a private method and the client code 
has no idea of the cost calculation business logic. The client code will simply pass the data to 
the CostCalculator and the rest will be done by its NetCalculation method. In other words, we 
aretelling the CostCalculator instance to perform the calculations,rather than asking anything from it.
*/