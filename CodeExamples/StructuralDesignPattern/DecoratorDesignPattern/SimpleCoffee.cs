namespace StructuralDesignPattern.DecoratorDesignPattern;

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 50.0; // সাধারণ কফির দাম ৫০ টাকা
    }
}
