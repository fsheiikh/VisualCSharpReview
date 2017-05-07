using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Checking : Account
    {
        public bool collegeStudent;
        public Checking(int number, decimal startingBalance, bool collegeStudentAcct = false) : base(number, startingBalance)
        {
            collegeStudent = collegeStudentAcct;
        }

        public override string ToString()
        {
            return String.Format("Checking Account#{0} has a balance of ${1}", accountID, accountBalance);
        }
        public override void closeMonth()
        {
            if (accountBalance < 1499 && !collegeStudent) accountBalance = accountBalance - Convert.ToDecimal(6.95);
            if (accountBalance < 1499 && collegeStudent) accountBalance = accountBalance - Convert.ToDecimal(3.95);
        }
    }
}

//Checking accounts charge a monthly fee of $6.95, however the fee is
//waived if the account balance is $1500 or more at the end of the month.Savings accounts pay
//interest monthly at an annual rate of 1.5% but only for those accounts with a balance of $2500
//or more.
//College students qualify for a lower $3.95 monthly fee on their Checking accounts which, like
//other Checking accounts is waived if the balance is $1500 or more. Senior citizens qualify for a
//rate of 2.0% on their Savings accounts.