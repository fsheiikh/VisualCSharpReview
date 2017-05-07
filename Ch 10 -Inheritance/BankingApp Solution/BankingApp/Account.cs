using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    class Account
    {
        private int accountID;
        public decimal accountBalance { get; private set; }


        public Account(int number, decimal startingBalance)
        {
            accountID = number;

            if (startingBalance > 299)
            {
                accountBalance = startingBalance;
                
            }
            else
            {
                throw new System.ArgumentException("Initial Amount must be $300 or more"); 
            }
        }
        public int getID()
        {
            return accountID;
        }

        public void withdraw(decimal amount)
        {
            if (accountBalance > amount)
                accountBalance -= amount;
            else if (amount <= 0)
            {
                DepositAmountException dae = new DepositAmountException();
                throw (dae);
            }
            else
                throw new System.ArgumentOutOfRangeException("Not Enough Money");
        }

        public void deposit(decimal amount)
        {
            if (amount <= 0)
            {
                DepositAmountException dae = new DepositAmountException();
                throw (dae);

            }
            else
            {
                accountBalance += amount;
            }
            
        }
    }


    class DepositAmountException : Exception
    {
        private static string msg = "Deposit Amount is Invalid";
        public DepositAmountException() : base(msg)
        {
        }
    }
}
