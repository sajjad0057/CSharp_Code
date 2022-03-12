using Static_Class;

/*
A static class is basically the same as a non-static class, but there is one difference:
a static class cannot be instantiated. In other words, you cannot use the new operator to 
create a variable of the class type. Because there is no instance variable, you access the
members of a static class by using the class name itself. For example, if you have a static 
class that is named UtilityClass that has a public static method named MethodA,you call the
method as shown in the following example: 

UtilityClass.MethodA(); 


The following list provides the main features of a static class:

    -Contains only static members.

    -Cannot be instantiated.

    -Is sealed.

    -Cannot contain Instance Constructors.
 */


Waterbottle b1 = new Waterbottle();
b1.color = "red";


Waterbottle b2 = new Waterbottle();

b2.color = "green";


Console.WriteLine(b1.color);
Console.WriteLine(b2.color);
Console.WriteLine(Waterbottle.count);


// Example of static class and uses of static class 

ExampleOfStaticClass.printArray(new int[] { 1, 2, 3, 4, 5, 6, });

Console.WriteLine("\n-----------------------------------------------------");

ExampleOfStaticClass.print2DArray(new int[,] { { 1, 2, 3, }, { 4, 5, 2 }, { 34, 465, 6 } });

