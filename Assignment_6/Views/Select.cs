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
using System.IO;

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

            // Outputs the value to the Product_info form


            Program.dollar_Computer_Data.Product_Id = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Productid].Value.ToString();
            Program.dollar_Computer_Data.Condition = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Condition].Value.ToString();
            Program.dollar_Computer_Data.Cost = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Cost].Value.ToString();
            Program.dollar_Computer_Data.Platform = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Platform].Value.ToString();
            Program.dollar_Computer_Data.OS = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Os].Value.ToString();
            Program.dollar_Computer_Data.Manufacturer = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Manufacturer].Value.ToString();
            Program.dollar_Computer_Data.Model = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Model].Value.ToString();
            Program.dollar_Computer_Data.Memory = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Memory].Value.ToString();
            Program.dollar_Computer_Data.LCD_Size = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Lcdsize].Value.ToString();
            Program.dollar_Computer_Data.Hdd = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Hdd].Value.ToString();
            Program.dollar_Computer_Data.CPU_Brand = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Cpubrand].Value.ToString();
            Program.dollar_Computer_Data.CPU_number = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Cpunumber].Value.ToString();
            Program.dollar_Computer_Data.GPU_Type = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Gputype].Value.ToString();
            Program.dollar_Computer_Data.CPU_Type = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Cputype].Value.ToString();
            Program.dollar_Computer_Data.CPU_speed = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Cpuspeed].Value.ToString();
            Program.dollar_Computer_Data.web_cam = cells[(int)Dollar_Computer_Data.Dollar_Computer_fields.Webcam].Value.ToString();

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.about_form.ShowDialog();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            // configure the file dialog

            dollar_computer_saveFileDialog1.FileName = "Product_Info.txt";


            dollar_computer_saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            dollar_computer_saveFileDialog1.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog

            var result = dollar_computer_saveFileDialog1.ShowDialog();
            if ( result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open("Product_Info.txt", FileMode.Create)))
                {
                    // write content - string type - to the file
                    outputStream.WriteLine(Program.dollar_Computer_Data.Product_Id.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Condition.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Cost.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Platform.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.OS.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Manufacturer.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Model.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Memory.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.LCD_Size.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.Hdd.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.CPU_Brand.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.CPU_number.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.CPU_Type.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.CPU_speed.ToString());
                    outputStream.WriteLine(Program.dollar_Computer_Data.web_cam.ToString());

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
