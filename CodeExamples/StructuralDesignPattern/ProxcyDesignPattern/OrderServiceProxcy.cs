namespace StructuralDesignPattern.ProxcyDesignPattern;

public interface IOrderService
{
    void PlaceOrder(string orderId);
}


public class OrderService : IOrderService
{
    public void PlaceOrder(string orderId)
    {
        Console.WriteLine($"Order {orderId} placed successfully.");
    }
}


public class OrderServiceProxy : IOrderService
{
    private readonly IOrderService _orderService;

    public OrderServiceProxy(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public void PlaceOrder(string orderId)
    {
        Console.WriteLine($"[Proxy] Logging: Order {orderId} is being placed...");

        _orderService.PlaceOrder(orderId); // Calling the real service

        Console.WriteLine($"[Proxy] Logging: Order {orderId} has been placed successfully.");
    }
}
