using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Task1
{
    public class BankAccount
    {
        public long AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public string IfscCode { get; set; }
        public bool IsCheckingAccount { get; set; }
        public AccountHolder AccountHolder { get; set; }
        public int AccountHolderId { get; set; }
        public int BankAccountId { get; set; }
    }
}
