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
 * Description: This is the Order form
 */
namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constant that represents the percentage of Sales Tax
        /// </summary>
        const decimal _SALES_TAX = 0.13m;
        
        /// <summary>
        ///  This is the shared event handler for the CancelButton and ExitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the shared event handler for the BackButton and BackToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// 
        /// </summary>
        public void PopulateOrderInformation()
        {
            //Fill up fields only when a product (Computer) is selected
            if (Program.product.productID != 0)
            {
                ConditionDataLabel.Text = Program.product.condition;
                PriceDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
                PlataformDataLabel.Text = Program.product.platform;
                OSDataLabel.Text = Program.product.OS;
                ManufacturerDataLabel.Text = Program.product.manufacturer;
                ModelDataLabel.Text = Program.product.model;
                MemoryDataLabel.Text = Program.product.RAM_size;
                LCDSizeDataLabel.Text = Program.product.screensize;
                HDDDataLabel.Text = Program.product.HDD_size;
                CPUBrandDataLabel.Text = Program.product.CPU_brand;
                CPUNumberDataLabel.Text = Program.product.CPU_number;
                GPUTypeDataLabel.Text = Program.product.GPU_Type;
                CPUTypeDataLabel.Text = Program.product.CPU_type;
                CPUSpeedDataLabel.Text = Program.product.CPU_speed;
                WebCamDataLabel.Text = Program.product.webcam;
                SalesTaxDataLabel.Text = ((decimal)(Program.product.cost * _SALES_TAX)).ToString("C");
                TotalDataLabel.Text = ((decimal)(Program.product.cost * (1 + _SALES_TAX))).ToString("C");
            }
        }
        /// <summary>
        /// This is the event handler for the OrderForm activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PopulateOrderInformation();
        }
        /// <summary>
        /// This is the event handler for the FinishButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thanks, We'll send you an e-mail with order deatils." + "\n\n" +
                "Your order will be processed in 2-3 business days.",
                "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        /// <summary>
        /// This is the evnt handler for the PrintToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Order...", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }
        /// <summary>
        /// This is the event handler for the OrderForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
