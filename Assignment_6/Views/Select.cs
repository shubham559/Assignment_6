using Assignment_6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Assignment_6.Views
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            using (var db = new Dollar_Computer_Context())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
