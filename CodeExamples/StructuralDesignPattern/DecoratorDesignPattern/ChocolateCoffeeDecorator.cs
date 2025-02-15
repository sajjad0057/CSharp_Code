namespace StructuralDesignPattern.DecoratorDesignPattern;

public class ChocolateCoffeeDecorator : CoffeeDecorator
{
    public ChocolateCoffeeDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Chocolate";
    }

    public override double GetCost()
    {
        return base.GetCost() + 20.0; // চকোলেট যোগ করলে ২০ টাকা বাড়বে
    }
}
