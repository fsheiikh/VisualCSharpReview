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

namespace _06_EnterInvoices
{
    public partial class Form1 : Form
    {

        const string DELIM = ",";
        const string FILENAME = "Invoice.txt";
        int num;
        string name;
        double amount;

        static FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInvoiceBox.Text);
            name = txtNameBox.Text;
            amount = Convert.ToDouble(txtAmountBox.Text);

            writer.WriteLine(num + DELIM + name + DELIM + amount);
            label1.Text = "Wrote to File";

            txtInvoiceBox.Clear();
            txtNameBox.Clear();
            txtAmountBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
