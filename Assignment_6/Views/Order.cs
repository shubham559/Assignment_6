using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6.Views
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.about_form.ShowDialog();
            this.Hide();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Program.Product_info_form.Show();
            this.Hide();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order Is being Printed:" + "\n\nPlease wait", "Wait",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks forPlacing the order:" + "\n\nYour order will be shipped within 7-10 business days", "Wait",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
