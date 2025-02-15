namespace StructuralDesignPattern.DecoratorDesignPattern;

public class SugerCoffeeDecorator : CoffeeDecorator
{
    public SugerCoffeeDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 5.0; // চিনি যোগ করলে ৫ টাকা বাড়বে
    }
}
