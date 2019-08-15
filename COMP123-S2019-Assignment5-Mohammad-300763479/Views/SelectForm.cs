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

namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SelectForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            using(var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                db.Dispose();
            }
        }
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var _rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var _currentRow = ProductDataGridView.Rows[_rowIndex];
            var _cells = _currentRow.Cells;

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

            SelectedProductTextBox.Text = Program.product.manufacturer.ToString() + " " +
                                         Program.product.model.ToString() + " " +
                                         ((decimal)Program.product.cost).ToString("C");

            NextButton.Enabled = true;
        }
        /// <summary>
        ///  This is the event handler for CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
    }
}
