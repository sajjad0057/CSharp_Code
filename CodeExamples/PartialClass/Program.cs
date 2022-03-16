using PartialClass;

Product p1 = new Product();
p1.Price = 200;
Console.WriteLine(p1.Name);
Console.WriteLine(p1.CalculateDiscount(20));
Console.WriteLine(p1.CalculatePriceAfterDiscount(20));
Product.Count = 0;
Console.WriteLine(Product.Count);