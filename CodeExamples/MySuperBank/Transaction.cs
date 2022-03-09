using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;

        }
    }
}
