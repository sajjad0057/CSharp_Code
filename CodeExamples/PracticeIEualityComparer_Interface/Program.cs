using PracticeIEualityComparer_Interface;

var person1 = new Person
{
    Id = 1,
    FirstName = "Sajjad",
    LastName = "Hossain"
};

var person2 = new Person
{
    Id = 2,
    FirstName = "Sajjad",
    LastName = "Hossain"
};

var compare = new PersonEqualityComparer();

Console.WriteLine(compare.Equals(person1, person2));

Console.WriteLine();