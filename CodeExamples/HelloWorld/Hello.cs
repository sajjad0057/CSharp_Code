

namespace HelloWorld;

public class Hello
{
    public int Id { get; set; } = 5;
    public string Name { get; set; } = "sajjad";

    public override string ToString() => Id.ToString()+Name;

}
