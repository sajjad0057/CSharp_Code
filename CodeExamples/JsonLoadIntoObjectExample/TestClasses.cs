namespace JsonLoadIntoObjectExample;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
}



public class PersonDetails
{
    public Address Address { get; set; }
    public Person Person { get; set; }
}