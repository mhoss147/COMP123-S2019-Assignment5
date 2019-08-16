using COMP123_S2019_Assignment5_Mohammad_300763479.Data;
using COMP123_S2019_Assignment5_Mohammad_300763479.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * App name: Dollar Computers
 * Author's Name: Mohammad S Hossain
 * Student ID: 300763479
 * App Creation Date: 02 August, 2019
 * Description: This is the Main Program class for application
 */
namespace COMP123_S2019_Assignment5_Mohammad_300763479
{
    public static class Program
    {
        public static Product product;

        //Dictionary to handle Form Names
        public static Dictionary<FormName, Form> Forms;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //creating forms from an ENUM
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());

            //creating a product object
            product = new Product();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }

    }
}

