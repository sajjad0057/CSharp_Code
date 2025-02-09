using CreationalDesignPatterns.CreationalDesignPatterns.AbstractFactory;
using CreationalDesignPatterns.CreationalDesignPatterns.BuilderPattern;
using CreationalDesignPatterns.CreationalDesignPatterns.Factory;
using CreationalDesignPatterns.CreationalDesignPatterns.Factory.Example_1;


#region FactoryMethodPattern

//// Examples of Factory Method Pattern :

//Console.WriteLine("Enter Car brands Name : " );

//var carBrandName = Console.ReadLine();

//var car = CarFactory.CreateCar( carBrandName );

//Console.WriteLine($"Model : {car.Model}; Color : {car.Color};");

var notification = NotificationFactory.CreateNotification("SMS");
notification.Send("Hello!");  // Output: SMS Sent: Hello!

#endregion


#region AbstractFactoryPattern

ICarFactory carFactory = new BMWCarFactory();

IEngine engine = carFactory.CreateEngine();
ITire tier = carFactory.CreateTier();

#endregion


#region BuilderPattern

EidCardBuilder cardBuilder = new EidCardBuilder()
    .AddMessage("Hello , Happy Eid Day !")
    .AddColor("Red")
    .AddDesign("Modern")
    .AddReceiverName("sajjad hossain");

EidCard card = cardBuilder.Build();

Console.WriteLine($"{card.ReceiverName}\n" +
    $"{card.Message}\n");

#endregion