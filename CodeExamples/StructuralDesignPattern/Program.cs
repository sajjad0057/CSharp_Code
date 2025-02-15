using StructuralDesignPattern.DecoratorDesignPattern;

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new MilkCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new SugerCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new ChocolateCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");