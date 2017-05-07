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

namespace _07_ViewInvoices
{
    public partial class Form1 : Form
    {

        const char DELIM = ',';
        const string FILENAME = @"C:\Users\MainUser\Desktop\DCCCD\C#\Ch 14 - Files_Streams\06_EnterInvoices Solution\06_EnterInvoices\bin\Debug\Invoice.txt";
        string recordIn; string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                txtInvoice.Text = fields[0];
                txtName.Text = fields[1];
                txtAmount.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                label1.Text = "You have viewed All records";
                button1.Enabled = false;
            }
            
 
        }
    }
}
