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
using System.Diagnostics;

namespace Assignment_6.Views
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This exit event exits the user from the application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_order_button_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {
            Size = new Size(600,500);
        }

        private void Open_saved_button_Click(object sender, EventArgs e)
        {


            // configure the file dialog


            dollar_Computer_openFileDialogopenFileDialog1.FileName = "Student.txt";
            dollar_Computer_openFileDialogopenFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            dollar_Computer_openFileDialogopenFileDialog1.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

                // open the file dialog
                var result = dollar_Computer_openFileDialogopenFileDialog1.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    try
                    {
                        // Open the  streawm for reading
                        using (StreamReader inputStream = new StreamReader(
                            File.Open(dollar_Computer_openFileDialogopenFileDialog1.FileName, FileMode.Open)))
                        {
                            // read from the file
                            Program.dollar_Computer_Data.Product_Id = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Model = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Cost = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Condition = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Platform = inputStream.ReadLine();
                            Program.dollar_Computer_Data.OS = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Manufacturer = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Model = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Memory = inputStream.ReadLine();
                            Program.dollar_Computer_Data.LCD_Size = inputStream.ReadLine();
                            Program.dollar_Computer_Data.Hdd = inputStream.ReadLine();
                            Program.dollar_Computer_Data.CPU_Brand = inputStream.ReadLine();
                            Program.dollar_Computer_Data.CPU_number = inputStream.ReadLine();
                            Program.dollar_Computer_Data.GPU_Type = inputStream.ReadLine();
                            Program.dollar_Computer_Data.CPU_Type = inputStream.ReadLine();
                            Program.dollar_Computer_Data.CPU_speed = inputStream.ReadLine();
                            Program.dollar_Computer_Data.web_cam = inputStream.ReadLine();

                            // cleanup
                            inputStream.Close();
                            inputStream.Dispose();
                        }

                    Open_saved_button_Click(sender, e);
                    }
                    catch (IOException exception)
                    {

                        Debug.WriteLine("ERROR: " + exception.Message);

                        MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException exception)
                    {
                        Debug.WriteLine("ERROR: " + exception.Message);

                        MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            

        }
    }
}
