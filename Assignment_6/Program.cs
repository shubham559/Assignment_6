using Assignment_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6.Views
{
     public static class Program
     {
        // staticc members
        public static Splash_form Splashform;
        public static Start_Form startform;
        public static Select selectform;
        public static Product_Info_form Product_info_form;
        public static Order order_form;
        public static About_form about_form;
        public static product product;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all forms
            Splashform = new Splash_form();
            startform = new Start_Form();
            selectform = new Select();
            Product_info_form = new Product_Info_form();
            order_form = new Order();
            about_form = new About_form();
            product = new product();



            Application.Run(new Splash_form());
        }
     }
}
