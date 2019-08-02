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
       public static Product product;
        public static SelectForm selectForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            selectForm = new SelectForm();
            product = new Product();

            Application.Run(selectForm);

        }
    }
}
