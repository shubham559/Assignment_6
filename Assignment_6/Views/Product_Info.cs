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
    public partial class Product_Info_form : Form
    {
        public Product_Info_form()
        {
            InitializeComponent();
        }

        private void Product_Info_form_Load(object sender, EventArgs e)
        {
            Size = new Size(750,550);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.about_form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CPU_NUMBER_Label_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_button_product_info_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
