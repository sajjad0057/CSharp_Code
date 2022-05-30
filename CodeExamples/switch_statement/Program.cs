using switch_statement;

Console.WriteLine("Hello, World!");



/// <summary>
/// Example of old switch statement : 
/// </summary>
static bool CheckIfCanWalkIntoBankSwitch(Bank bank, bool isVip)
{
    switch (bank.Status)
    {
        case BankBranchStatus.Open:
            return true;
        case BankBranchStatus.Closed:   //// here not need to use break ; cz , here return directly 
            return false;
        case BankBranchStatus.VIPCustomersOnly:
            return isVip;
        default:
            return false;
    }
}



/// <summary>
/// Example of New switch statement And It's Feature : 
/// </summary>
/// 

static bool CheckIfCanWalkIntoBank(Bank bank,bool isVip) =>
    bank.Status switch
    {
        BankBranchStatus.Open => true,
        BankBranchStatus.Closed => false,
        BankBranchStatus.VIPCustomersOnly => isVip,
        _ => false,

    };


/// <summary>
/// Example of Case Guards in switch expression
/// </summary>

static bool CheckIfCanWalkIntoBank4(Bank bank, bool isVip)
{
    return bank.Status switch
    {
        BankBranchStatus.Open => true,
        BankBranchStatus.Closed => false,
        BankBranchStatus.VIPCustomersOnly when isVip => true,   //// check some new condition or case using when keyword ,
        BankBranchStatus.VIPCustomersOnly when !isVip => false,
        _ => false
    };
}


/// <summary>
/// using tuple  check multiple value in new switch expression
/// </summary>


static bool CheckIfCanWalkIntoBank5(Bank bank, bool isVip)
{
    return (bank.Status, isVip) switch
    {
        (BankBranchStatus.Open, _) => true,   // here _ indicate default value .
        (BankBranchStatus.Closed, _) => false,
        (BankBranchStatus.VIPCustomersOnly, true) => true,
        (BankBranchStatus.VIPCustomersOnly, false) => false,
        (_, _) => false
    };
}



/// <summary>
/// Example of Using, Object and Check value One Or Value in switch statement / expression 
/// </summary>




static bool CheckIfCanWalkIntoBank6(Bank bank, bool isVip)
{
    return bank switch
    {
        { Status: BankBranchStatus.Open, Name: _ } => true,        // here _ indicate default value .
        { Status: BankBranchStatus.Closed, Name : "something"} => false, 
        { Status: BankBranchStatus.VIPCustomersOnly , Name: "ABC" } => isVip,    
        { Status: _ } => false
    };
}