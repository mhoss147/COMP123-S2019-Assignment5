using COMP123_S2019_Assignment5_Mohammad_300763479.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * App name: Dollar Computers
 * Author's Name: Mohammad S Hossain
 * Student ID: 300763479
 * App Creation Date: 02 August, 2019
 * Description: This is the Product select form for application
 */
namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
       
        /// <summary>
        /// This is the event handler for the SelectForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                db.Dispose();
            }
            //Disable Next button until any selection made
            NextButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler for the ProductsDataGridView Selection Changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local variables 
            var _rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var _currentRow = ProductsDataGridView.Rows[_rowIndex];
            var _cells = _currentRow.Cells;

            //Create a computer object with information from a line selected in DataGridView
            Program.product.productID = short.Parse(_cells[(int)ProductFields.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(_cells[(int)ProductFields.COST].Value.ToString());
            Program.product.manufacturer = _cells[(int)ProductFields.MANUFACTURER].Value.ToString();
            Program.product.condition = _cells[(int)ProductFields.CONDITION].Value.ToString();
            Program.product.platform = _cells[(int)ProductFields.PLATFORM].Value.ToString();
            Program.product.OS = _cells[(int)ProductFields.OS].Value.ToString();
            Program.product.model = _cells[(int)ProductFields.MODEL].Value.ToString();
            Program.product.RAM_size = _cells[(int)ProductFields.RAM_SIZE].Value.ToString();
            Program.product.screensize = _cells[(int)ProductFields.SCREEN_SIZE].Value.ToString();
            Program.product.HDD_size = _cells[(int)ProductFields.HDD_SIZE].Value.ToString();
            Program.product.CPU_brand = _cells[(int)ProductFields.CPU_BRAND].Value.ToString();
            Program.product.CPU_number = _cells[(int)ProductFields.CPU_NUMBER].Value.ToString();
            Program.product.GPU_Type = _cells[(int)ProductFields.GPU_TYPE].Value.ToString();
            Program.product.CPU_type = _cells[(int)ProductFields.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = _cells[(int)ProductFields.CPU_SPEED].Value.ToString();
            Program.product.webcam = _cells[(int)ProductFields.WEBCAM].Value.ToString();

            //Input for Selection TextBox
            SelectedProductTextBox.Text = $"{Program.product.manufacturer} - {Program.product.model} \t Price: {Convert.ToDouble(Program.product.cost.ToString()):C2}";


            //Enable Next button after selecion
            NextButton.Enabled = true;

            ProductInfoForm form = Program.Forms[FormName.PRODUCT_INFO_FORM] as ProductInfoForm;
            form.PopulateProductInformation();
        }
        /// <summary>
        /// This is the event handler for the SelectForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
