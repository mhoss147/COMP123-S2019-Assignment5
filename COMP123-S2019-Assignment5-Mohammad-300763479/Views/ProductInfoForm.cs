using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * App name: Dollar Computers
 * Author's Name: Mohammad S Hossain
 * Student ID: 300763479
 * App Creation Date: 02 August, 2019
 * Description: This is the ProductInfo form for application
 */
namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //This disable the Next button until user select any row
            NextButton.Enabled = false;
        }
        /// <summary>
        /// This method populate ProductInfoForm with computer object info 
        /// </summary>
        public void PopulateProductInformation()
        {
            //This fill up fields when a product (Computer) is selected
            if (Program.product.productID != 0)
            {
                ProductIDDataLabel.Text = Program.product.productID.ToString();
                ConditionDataLabel.Text = Program.product.condition;
                CostDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
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

                //This is to enabble Next button after form filled
                NextButton.Enabled = true;
            }
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            PopulateProductInformation();
        }
       
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
            OrderForm form = Program.Forms[FormName.ORDER_FORM] as OrderForm;
            form.PopulateOrderInformation();
        }
        /// <summary>
        /// This is the shared event handler for the SelectAnotherProductButton and SelectAnotherProductToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the shared event handler for the CancelButton and exitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }
        /// <summary>
        /// This method opens a OpenFileDialog.
        /// </summary>
        public void OpenFileDialog()
        {
            //This is to configure the file dialog
            SelectOrderOpenFileDialog.FileName = "Product";
            SelectOrderOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectOrderOpenFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            SelectOrderOpenFileDialog.DefaultExt = ".txt";

            //This is to open file dialog
            var _result = SelectOrderOpenFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(SelectOrderOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //This is to read data from the file into the Product object
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //This is for cleaning up
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateProductInformation();
        }
        /// <summary>
        /// This is the event handler for the SaveToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is to Configure the file dialog
            SelectOrderSaveFileDialog.FileName = "Product";
            SelectOrderSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectOrderSaveFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            SelectOrderSaveFileDialog.DefaultExt = ".txt";

            //This is to Open file dialog
            var _result = SelectOrderSaveFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    //This is to Open stream to write
                    using (StreamWriter outputStream = new StreamWriter(
                        File.Open(SelectOrderSaveFileDialog.FileName, FileMode.Create)))
                    {
                        //This is to Write data to the file
                        outputStream.WriteLine(Program.product.productID.ToString());
                        outputStream.WriteLine(Program.product.condition);
                        outputStream.WriteLine(Program.product.cost);
                        outputStream.WriteLine(Program.product.platform);
                        outputStream.WriteLine(Program.product.OS);
                        outputStream.WriteLine(Program.product.manufacturer);
                        outputStream.WriteLine(Program.product.model);
                        outputStream.WriteLine(Program.product.RAM_size);
                        outputStream.WriteLine(Program.product.screensize);
                        outputStream.WriteLine(Program.product.HDD_size);
                        outputStream.WriteLine(Program.product.CPU_brand);
                        outputStream.WriteLine(Program.product.CPU_number);
                        outputStream.WriteLine(Program.product.GPU_Type);
                        outputStream.WriteLine(Program.product.CPU_type);
                        outputStream.WriteLine(Program.product.CPU_speed);
                        outputStream.WriteLine(Program.product.webcam);

                        //This is to Cleanup
                        outputStream.Close();
                        outputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("File saved successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
