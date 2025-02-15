namespace StructuralDesignPattern.DecoratorDesignPattern;

public class MilkCoffeeDecorator : CoffeeDecorator
{
    public MilkCoffeeDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 10.0; // দুধ যোগ করলে ১০ টাকা বাড়বে
    }
}
