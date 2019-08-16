﻿using System;
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
    }
}
