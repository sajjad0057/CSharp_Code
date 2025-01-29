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

    /// <summary>
    /// If we initialize property here , then if we try to serialize this object it will be serialized with this initilized
    /// property , otherwise it serilize with null value
    /// </summary>
    public Address Address { get; set; } = new Address();
    public IList<Phone> Contacts { get; set; } = new List<Phone>();
}



public class PersonDetails
{
    public Address Address { get; set; }
    public Person Person { get; set; }
}


public class Phone
{
    public string Contact { get; set; } 
}