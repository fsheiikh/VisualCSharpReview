using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Farhan Sheikh; 04/09/2017
namespace BankingApp
{
    public partial class Bank : Form
    {
        int count = 0; //this is the number we use to keep count of account numbers
        Account[] accounts = new Account[20]; //initilize an array of 20 aaounts (0-19 : indexes)

        ///////////////////////////////////////////////////////////////////////////
        const string DELIM = ",";
        const string FILENAME = @"C:\Users\MainUser\Desktop\DCCCD\C#\Ch 14 - Files_Streams\BankInfo1.txt";

        int AccountId;
        Decimal AccountBalance;


        //static FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        ////////////////////////////////////////////////////////////////////////////////
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke; //reset form color
            label3.Text = String.Empty; // resets the error label

            int accountID;
            Int32.TryParse(txtAccount.Text, out accountID); //get Account ID based on number in Account TextBox

            try
            {
                Account account = accounts[accountID - 1]; //we use the accountID -1 to get the index of the account and set to an account variable

                if (radioBalance.Checked)
                {
                    lblMessage.Text = String.Format("Account#{0} has a balance of ${1}",
                                                    account.getID(), account.accountBalance);
                }
                else if (radioWithdraw.Checked)
                {
                    decimal withdrawAmount;
                    Decimal.TryParse(txtAmount.Text, out withdrawAmount);


                    account.withdraw(withdrawAmount);
                    this.BackColor = System.Drawing.Color.RosyBrown;
                    lblMessage.Text = String.Format("${0} withdrawn from Account#{1}",
                                                    withdrawAmount, account.getID());



                }
                else if (radioDeposit.Checked)
                {
                    decimal depositAmount;
                    Decimal.TryParse(txtAmount.Text, out depositAmount);

                    account.deposit(depositAmount);
                    lblMessage.Text = String.Format("${0} deposited into Account#{1}",
                                                    depositAmount, account.getID());
                }
            }
            catch (System.ArgumentOutOfRangeException ex) //if there was any error with input we catch the error and let the user know
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Not Enough Money";

            }
            catch (System.NullReferenceException ex)
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "That Account doesn't exist";
            }
            catch (BankingApp.DepositAmountException ex)
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Amount must be above 0";
            }
            catch (System.IndexOutOfRangeException ex)
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Amount Number Invalid";
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            label3.Text = String.Empty;
            

            if (count < 20)
            {
                try
                {
                    
                    if (radioChecking.Checked)   
                        accounts[count] =  (checkBoxStudent.Checked) ? new Checking(count += 1, Convert.ToDecimal(txtAmount.Text), true) : 
                                                                       new Checking(count += 1, Convert.ToDecimal(txtAmount.Text));
                    else
                        accounts[count] = (checkBoxSenior.Checked) ? new Savings(count += 1, Convert.ToDecimal(txtAmount.Text), true) :
                                                                     new Savings(count += 1, Convert.ToDecimal(txtAmount.Text));


                    lblMessage.Text = accounts[count - 1].ToString();

                    txtAccount.Text = accounts[count - 1].getID().ToString();
                }
                catch (System.FormatException ex)
                {
                    label3.Text = "Not a Valid Number, Enter Again Please";
                    txtAmount.Text = String.Empty;
                }
                catch (System.ArgumentException es)
                {
                    label3.Text = "Amount Must be above $299";
                    txtAmount.Text = String.Empty;
                }
            }
            else
            {
                label3.Text = "Too Many Accounts";
            }

            StreamWriter writer = new StreamWriter(FILENAME, true);

            AccountId = accounts[count - 1].getID();
            AccountBalance = accounts[count - 1].accountBalance;

            writer.WriteLine(AccountId + DELIM + AccountBalance);
            writer.Close();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseMonth_Click(object sender, EventArgs e)
        {
            foreach (var acct in accounts)
            {
                if (acct != null)
                {
                    acct.closeMonth();
                    lblMessage.BackColor = System.Drawing.Color.Green;
                    lblMessage.Text = "End of Month Process Complete";
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = System.Drawing.Color.Green;

            foreach (var acct in accounts)
            {
                if (acct != null)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text += "\n" + acct.ToString() + "\n";
                }
            }

        }

        private void btnUpdateFromRecords_Click(object sender, EventArgs e)//updates the accounts and also is able to display 
        {
            string recordIn;
            string[] fields;
            int numberOfRecords = 0;
            //FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(FILENAME, true);
            try
            {
                while ((recordIn = reader.ReadLine()) != null) //got from microsoft docs -> msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
                {
                    //recordIn = reader.ReadLine();
                    fields = recordIn.Split(',');
                    //lblMessage.Text += String.Format("\n ID : {0}, Balance: {1} \n", fields[0], fields[1]);
                    numberOfRecords += 1;
                    lblMessage.Text = String.Format("Loaded {0} Records", numberOfRecords);
                    var newTempAcct = new tempAccount(Convert.ToInt32(fields[0]), Convert.ToDecimal(fields[1]));
                    accounts[count] = newTempAcct;
                    count += 1;
                }

            }
            catch (NullReferenceException)
            {
                label1.Text = "You have viewed All records";
                //button1.Enabled = false;
            }
            reader.Close();
        }
    }

}
