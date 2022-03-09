using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class BankAccount
    {
        public string Number { get; set; }

        public string Ownar { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 10000000;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Ownar = name;
            this.Number = accountNumberSeed.ToString();

            accountNumberSeed++;

            MakeDeposite(initialBalance, DateTime.Now, "Inital Balance");


        }

        public void MakeDeposite(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposite Must be Positive Value");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);

        }

        public void Makewithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal Must be Positve Value");

            }
            if (Balance - amount <= 0)
            {
                throw new InvalidOperationException("Not Sufficient Funds For This Widthdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);


        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote\n" +
                "==============================================================");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");

            }

            return report.ToString();

        }


    }
}
