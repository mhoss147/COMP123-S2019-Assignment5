using COMP123_S2019_Assignment5_Mohammad_300763479.Data;
using COMP123_S2019_Assignment5_Mohammad_300763479.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_Mohammad_300763479
{
    public static class Program
    {
        //// static members
        //public static SplashForm splashForm;
        //public static StartForm startForm;
        //public static SelectForm selectForm;
        //public static ProductInfoForm productInfoForm;
        //public static OrderForm orderForm;
        //public static AboutForm aboutForm;

        //public static Product product;

        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    // Instantiate all forms here
        //    aboutForm = new AboutForm();
        //    splashForm = new SplashForm();
        //    startForm = new StartForm();
        //    selectForm = new SelectForm();
        //    productInfoForm = new ProductInfoForm();
        //    orderForm = new OrderForm();
        //    product = new Product();

        //    Application.Run(splashForm);


        public static Product product;

        //Using a Dictionary and an ENUM to handle Form Names
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
}
