using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{

    public class Bank
    {
        public BankBranchStatus Status { get; set; }

    }

    public enum BankBranchStatus
    {
        Open,
        Closed,
        VIPCustomersOnly
    }

}
