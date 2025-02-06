
/*
Here practicing custom attribute creation and uses for console application
*/
using P_CustomAttribute;

var user = new User
{
    Name = "john doe", // No capital letter → should fail
    Email = "john@example.com"
};

var validationResults = ModelValidator.ValidateModel(user);

if (validationResults.Count == 0)
{
    Console.WriteLine("User is valid!");
}
else
{
    foreach (var error in validationResults)
    {
        Console.WriteLine($" - {error.ErrorMessage}");
    }
}
