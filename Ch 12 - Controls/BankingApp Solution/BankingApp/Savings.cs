using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
    //The Savings and Checking classes are derived from the Account class. They both override
    //the closeMonth method.They also override the ToString method to return a string like,
    //“Savings account #4 has a balance of $4235.03”
{
    class Savings : Account
    {
        public bool seniorCitizen;
        public Savings(int number, decimal startingBalance, bool seniorCitizenAcct = false) : base(number, startingBalance)
        {
            seniorCitizen = seniorCitizenAcct;
            Console.WriteLine(seniorCitizen);
        }

        public override string ToString()
        {
            return String.Format("Savings Account#{0} has a balance of ${1}", accountID, accountBalance);
        }

        public override void closeMonth()
        {
            if (accountBalance > 2499 && !seniorCitizen) accountBalance += (accountBalance * Convert.ToDecimal(0.125));
            if (accountBalance > 2499 && seniorCitizen) accountBalance += (accountBalance * Convert.ToDecimal(0.166));
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