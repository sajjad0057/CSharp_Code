﻿using CreationalDesignPatterns.CreationalDesignPatterns.AbstractFactory;
using CreationalDesignPatterns.CreationalDesignPatterns.Factory;


#region FactoryMethodPattern

//// Examples of Factory Method Pattern :

//Console.WriteLine("Enter Car brands Name : " );

//var carBrandName = Console.ReadLine();

//var car = CarFactory.CreateCar( carBrandName );

//Console.WriteLine($"Model : {car.Model}; Color : {car.Color};");

#endregion


#region AbstractFactoryPattern

ICarFactory carFactory = new BMWCarFactory();

IEngine engine = carFactory.CreateEngine();
ITire tier = carFactory.CreateTier();

#endregion