using P_CustomAttribute.CustomAttribute;

namespace P_CustomAttribute;

//[RequiresCapitalLetter]
public class User
{
    [RequiresCapitalLetter]
    public string Name { get; set; }
    [RequiresCapitalLetter]
    public string Email { get; set; }
}
