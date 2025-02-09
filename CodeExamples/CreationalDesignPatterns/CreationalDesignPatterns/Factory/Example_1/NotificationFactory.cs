namespace CreationalDesignPatterns.CreationalDesignPatterns.Factory.Example_1;

// Step 1: Create an interface for notifications
public interface INotification
{
    void Send(string message);
}

// Step 2: Implement concrete notification types
public class SMSNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"SMS Sent: {message}");
}

public class EmailNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"Email Sent: {message}");
}

// Step 3: Factory class to create objects
public class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type switch
        {
            "SMS" => new SMSNotification(),
            "Email" => new EmailNotification(),
            _ => throw new Exception("Invalid Notification Type")
        };
    }
}