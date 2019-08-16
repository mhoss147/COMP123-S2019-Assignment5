using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Mohammad S Hossain
 * Student ID: 300763479
 * Description: This is the program Start form
 */
namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for StartNewOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        ///  This is the event handler for OpenSavedOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            var productInfoForm = Program.Forms[FormName.PRODUCT_INFO_FORM] as ProductInfoForm;
            productInfoForm.Show();
            productInfoForm.OpenFileDialog();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the ExitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
