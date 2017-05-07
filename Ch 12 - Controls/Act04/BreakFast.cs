using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_04
{
    public partial class BreakFast : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;
        private const double FULL_BREAKFAST_PRICE = 9.95;
        private const double DELUXE_BREAKFAST_PRICE = 16.50;


        public BreakFast()
        {
            InitializeComponent();
        }

        private void BreakFast_Load(object sender, EventArgs e)
        {
            lblPrice.Text = "Price" + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void radioContinental_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void radioFull_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void radioDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }
}
