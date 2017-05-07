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
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        private void bellaireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bellaireCheckBox.Checked)
            {
                BellAire bellAire = new BellAire();
                bellAire.ShowDialog();
                bellaireCheckBox.Checked = false;
            }



        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            BreakFast breakfast = new BreakFast();
            breakfast.ShowDialog();

        }
    }
}
