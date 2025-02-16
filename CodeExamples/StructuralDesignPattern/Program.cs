using StructuralDesignPattern.DecoratorDesignPattern;
using StructuralDesignPattern.ProxcyDesignPattern;



Console.WriteLine("-----------------> Example for Decorator design pattern ------------------->");
ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new MilkCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new SugerCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");

coffee = new ChocolateCoffeeDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} Tk");


Console.WriteLine("-------------------> Example for Proxcy Design pattern ------------------>");

// Create the real service
IOrderService orderService = new OrderService();

// Wrap it with the proxy
IOrderService proxy = new OrderServiceProxy(orderService);

// Use the proxy instead of directly using the real service
proxy.PlaceOrder("12345");

Console.ReadLine();