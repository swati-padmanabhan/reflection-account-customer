using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectorAccountCustomer.models
{
    internal class Account
    {

        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }


        public Account(int accountId, string accountHolderName) 
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
        }

        public void OpenAccount() { }

        public void CloseAccount() { }
    }
}
