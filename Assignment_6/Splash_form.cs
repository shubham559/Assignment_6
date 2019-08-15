using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Splash_form : Form
    {
        public Splash_form()
        {
            InitializeComponent();
        }

        private void Splash_timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Start_Form start_Form = new Start_Form();
            start_Form.Show();
            Splash_timer.Enabled = false;
        }
    }
}
