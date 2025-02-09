using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Example_1;

// Step 1: Create an interface for strategy
public interface IPaymentStrategy
{
    void Pay(int amount);
}

// Step 2: Implement different payment strategies
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount) => Console.WriteLine($"Paid {amount} via Credit Card");
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount) => Console.WriteLine($"Paid {amount} via PayPal");
}

// Step 3: Context class to use strategies
public class PaymentContext
{
    private IPaymentStrategy _strategy;

    public PaymentContext(IPaymentStrategy strategy) => _strategy = strategy;

    public void ExecutePayment(int amount) => _strategy.Pay(amount);
}
