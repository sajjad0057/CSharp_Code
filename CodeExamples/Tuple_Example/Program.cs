using Tuple_Example;

// Tuple example :

/*
Concise Syntax :

with variable Name :

( dataType1 variable1 , dataType2 variable2 , . . . . ) tupleName = ( value1, value2 , . . . . );

Or :

with variable less :

( dataType1 , dataType2 , . . . . ) tupleName = ( value1, value2 , . . . . );


or :

array types tuple with variable Name :

( dataType1 variable1 , dataType2 variable2 , . . . . )[] tupleName =new ( dataType1, dataType2 , . . . . )[];

array types tuple with variable less :

( dataType1 , dataType2  , . . . . )[] tupleName =new ( dataType1, dataType2 , . . . . )[];



*/





(string name, int age) Person = ("sajjad", 24);
Console.WriteLine($"Name : {Person.name} ;  Age : {Person.age}");

(string, double) food = ("Burger", 5.5);
Console.WriteLine($"Food Name : {food.Item1} ; Price : $ {food.Item2}");




Console.WriteLine("=============================================================================");
Console.WriteLine("Practice tuple with OOP : ");
Console.WriteLine();


Customer[] customers = new Customer[3];  // declare array 

Order[] orders = new Order[3];   // declare array 

Customer customer1 = new Customer { Id = 1, Name = "sajjad", Address = "Pabna"};

Customer customer2 = new Customer { Id = 2, Name = "mahdi", Address = "Chapai" };

Customer customer3 = new Customer { Id = 3, Name = "nafiul", Address = "Gazipur" };


Order order1 = new Order
{
    Id = 1,
    CustomerId = customer1.Id,
    OrderDate = new DateTime(2022, 3, 10),
    TotalAmount = 545.00
};

Order order2 = new Order
{
    Id = 2,
    CustomerId = customer2.Id,
    OrderDate = new DateTime(2022, 3, 14),
    TotalAmount = 460.00

};

Order order3 = new Order
{
    Id = 3,
    CustomerId = customer3.Id,
    OrderDate = new DateTime(2022, 2, 23),
    TotalAmount = 560.00
};



customers[0] = customer1;
customers[1] = customer2;
customers[2] = customer3;

orders[0] = order1;
orders[1] = order2;
orders[2] = order3;


// declare a array typed tuple 

(string name, double amount)[] data = new (string, double)[3];

int index = 0;

for (int i = 0; i < orders.Length; i++)
{
    if(orders[i].TotalAmount > 500)
    {
        for (int j = 0; j < customers.Length; j++)
        {
            if(orders[i].CustomerId == customers[j].Id)
            {
                data[index++] = (customers[j].Name, orders[i].TotalAmount);
            }
        }
    }
}


for (int i = 0; i < index; i++)
{
    Console.WriteLine($"Name : {data[i].name} ; Amount : {data[i].amount}");
}




