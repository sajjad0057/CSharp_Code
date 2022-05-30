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
/// Example of New switch statement : 
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
