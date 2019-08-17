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
         //   Program.about_form.Show();
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

        private void Product_info_activated(object sender, EventArgs e)
        {
            product_id_result_label.Text = Program.dollar_Computer_Data.Product_Id.ToString();
            cost_label_result.Text = Program.dollar_Computer_Data.Cost.ToString();
            condition_label_result.Text = Program.dollar_Computer_Data.Condition.ToString();
            Platform_label_result.Text = Program.dollar_Computer_Data.Platform.ToString();
            OS_result_label.Text = Program.dollar_Computer_Data.OS.ToString();
            Manufacturer_label_result.Text = Program.dollar_Computer_Data.Manufacturer.ToString();
            Model_label_result.Text = Program.dollar_Computer_Data.Model.ToString();
            Memory_label_result.Text = Program.dollar_Computer_Data.Memory.ToString();
            LCD_Size_result_label.Text = Program.dollar_Computer_Data.LCD_Size.ToString();
            HDD_result_label.Text = Program.dollar_Computer_Data.Hdd.ToString();
            CPU_Brand_label_result.Text = Program.dollar_Computer_Data.CPU_Brand.ToString();
            CPU_NUMBER_RESULT_LABEL.Text = Program.dollar_Computer_Data.CPU_number.ToString();
            GPU_TYPE_LABEL_RESULT.Text = Program.dollar_Computer_Data.GPU_Type.ToString();
            CPU_TYPE_LABEL_result.Text = Program.dollar_Computer_Data.CPU_Type.ToString();
            CPUSpeed_RESULT_LABEL.Text = Program.dollar_Computer_Data.CPU_speed.ToString();
            web_Cam_label_result.Text = Program.dollar_Computer_Data.web_cam.ToString();

        }

        private void Next_button_product_info_form_Click(object sender, EventArgs e)
        {
            Program.order_form.Show();
            this.Hide();
        }

        private void Select_another_product_button_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order Is being Printed:" + "\n\nPlease wait", "Wait",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
