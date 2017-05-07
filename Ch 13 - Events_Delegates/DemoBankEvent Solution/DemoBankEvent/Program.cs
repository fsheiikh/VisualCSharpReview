using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBankEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            //var newAccount = new BankAccount(1);
            //var evt = new EventListener(newAccount);

            //newAccount.MakeDeposit(14.99);
            //newAccount.MakeWithdrawal(5.99);

            var Demo = new DemoBankAccountEvent();
            Demo.Main();

            Console.ReadLine();
        }
    }

    class BankAccount
    {
        private int acctNum;
        private double balance;
        public event EventHandler BalanceAdjusted;

        public BankAccount(int acct)
        {
            acctNum = acct;
            balance = 0;
        }

        public int AcctNum{ get { return acctNum; } }

        public double Balance { get { return balance; } }

        public void MakeDeposit(double amt)
        {
            balance += amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }

        public void MakeWithdrawal(double amt)
        {
            balance -= amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }

        public void OnBalanceAdjusted(EventArgs e)
        {
            BalanceAdjusted(this, e);
        }
    }

    class EventListener
    {
        public BankAccount acct;
        public EventListener(BankAccount account)
        {   
            acct = account;
            acct.BalanceAdjusted += new EventHandler(BankAccountBalanceAdjusted);
        }

        public void BankAccountBalanceAdjusted(object sender, EventArgs e)
        {
            Console.WriteLine("The account balance has been adjusted. ");
            Console.WriteLine("Account #{0} balance {1}", acct.AcctNum, acct.Balance.ToString("C2"));
        }

    }

    public class DemoBankAccountEvent
    {
        public void Main()
        {
            const int TRANSACTIONS = 5;
            char code;
            double amt;

            BankAccount acct = new BankAccount(334455);
            EventListener listener = new EventListener(acct);

            for (int i = 0; i < TRANSACTIONS ; i++)
            {
                Console.WriteLine("Enter D for deposit or W for Withdrawal ");
                code = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter dollar amount ");
                amt = Convert.ToDouble(Console.ReadLine());

                if (code == 'D') acct.MakeDeposit(amt);
                else acct.MakeWithdrawal(amt);
            }

            Console.WriteLine("After Loop in DEMOBANKACCOUNTEVENT METHOD");

        }
    }
}
