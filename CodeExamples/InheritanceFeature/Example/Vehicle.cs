namespace InheritanceFeature.Example;

public class Vehicle   // Base Class
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    // Constructor Overloading in Base Class
    public Vehicle()
    {
        Brand = "Unknown";
        Speed = 0;
        Console.WriteLine("Vehicle Default Constructor Called");
    }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
        Console.WriteLine($"Vehicle Parameterized Constructor Called: {Brand}, Speed: {Speed}");
    }

    // Virtual Method (for Overriding)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: Brand={Brand}, Speed={Speed} km/h");
    }

    // Method Overloading: Multiple versions of Accelerate()
    public void Accelerate()
    {
        Speed += 10;
        Console.WriteLine($"Vehicle accelerated. New Speed: {Speed} km/h");
    }

    public void Accelerate(int amount)
    {
        Speed += amount;
        Console.WriteLine($"Vehicle accelerated by {amount}. New Speed: {Speed} km/h");
    }
}


class Car : Vehicle
{
    public int SeatingCapacity { get; set; }

    // Constructor Overloading in Derived Class
    public Car() : base()  // Calls base class default constructor
    {
        SeatingCapacity = 5;
        Console.WriteLine("Car Default Constructor Called");
    }

    public Car(string brand, int speed, int seatingCapacity) : base(brand, speed)  // Calls base parameterized constructor
    {
        SeatingCapacity = seatingCapacity;
        Console.WriteLine($"Car Parameterized Constructor Called: Seating={SeatingCapacity}");
    }

    // Overriding base class method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car: Brand={Brand}, Speed={Speed} km/h, Seating={SeatingCapacity}");
    }
}


// Derived Class 2: Bike
class Bike : Vehicle
{
    public bool HasGear { get; set; }

    // Constructor Overloading in Derived Class
    public Bike() : base()  // Calls base class default constructor
    {
        HasGear = false;
        Console.WriteLine("Bike Default Constructor Called");
    }

    public Bike(string brand, int speed, bool hasGear) : base(brand, speed)  // Calls base parameterized constructor
    {
        HasGear = hasGear;
        Console.WriteLine($"Bike Parameterized Constructor Called: HasGear={HasGear}");
    }

    // Overriding base class method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike: Brand={Brand}, Speed={Speed} km/h, HasGear={HasGear}");
    }
}

