using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("sajjad hossain", 100);
            var a = new BankAccount("dfh", 5000);
            Console.WriteLine($"Account {account.Number} was created for {account.Ownar} with ${account.Balance}");
            Console.WriteLine($"Account {a.Number} was created for {a.Ownar} with ${a.Balance}");

            account.Makewithdrawal(50, DateTime.Now, "Payment for Rent");
            Console.WriteLine($"Account {account.Number} was created for {account.Ownar} with ${account.Balance}");

            account.MakeDeposite(25, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"Account {account.Number} was created for {account.Ownar} with ${account.Balance}");

            Console.WriteLine("<===========================================================>");

            try
            {
                account.Makewithdrawal(5, DateTime.Now, "Payment for something");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("<===========================================================>");

            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("Invalid-1", -100);

            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}


            Console.WriteLine($"{account.Number} A/C  History : \n" +
                $"{account.GetAccountHistory()}");


        }
    }

}
