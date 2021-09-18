using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Task1
{
    public class AccountHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public bool IsMilitaryVeteran { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public int AccountHolderId { get; set; }
    }
}
