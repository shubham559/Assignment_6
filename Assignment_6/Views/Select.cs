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

        /// <summary>
        /// this event loads the database into the datagrid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Select_Load(object sender, EventArgs e)
        {
            using (var db = new Dollar_Computer_Context())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }

           
        }

        private void Product_datagrid_view_selection_changed(object sender, EventArgs e)
        {
            // aliasesto output the selected result

            var currentcell = Product_Data_Grid_View.CurrentCell;
            var row_index = Product_Data_Grid_View.CurrentCell.RowIndex;
            var current_row = Product_Data_Grid_View.Rows[row_index];
            var column_count = Product_Data_Grid_View.ColumnCount;
            var cells = current_row.Cells;

            // displays the selected row result on the label
            string output_string = string.Empty;

            for (int index = 0; index < column_count; index++)
            {
                output_string += cells[index].Value.ToString() + " ";

            }

            Result_Show_select_form.Text = output_string;


        }

        /// <summary>
        /// This event when triggered exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if(Result_Show_select_form.Text == "")
            {
                Next_button.Enabled = false;
            }

            else
            {
                Program.Product_info_form.Show();
                this.Hide();

            }


        }

        private void Product_datagrid_view_cell_click(object sender, EventArgs e)
        {

        }

        private void Product_data_grid_view_cell_click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
