using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Farhan Sheikh; 04/09/2017
namespace BankingApp
{
    public partial class Bank : Form
    {
        int count = 0; //this is the number we use to keep count of account numbers
        Account[] accounts = new Account[20]; //initilize an array of 20 aaounts (0-19 : indexes)
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
                    accounts[count] = (new Account(count += 1, Convert.ToDecimal(txtAmount.Text)));
                    lblMessage.Text = String.Format("Account #{0} Opened with a balance of ${1}",
                                        accounts[count - 1].getID(), accounts[count - 1].accountBalance);

                    //next two lines good for debugging since theu display all accounts
                    //label3.Text += String.Format("Account #{0} has {1} in it \n",
                    // accounts[count - 1].getID(), accounts[count - 1].accountBalance);

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

            
        
            
        }
    }

}
