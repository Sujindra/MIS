using BIIS.BusinessLogics;
using System;
using System.Windows.Forms;

namespace BIIS.Views
{
    public partial class Export : MetroFramework.Forms.MetroForm
    {
        public Export()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIISDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.bIISDataSet.Product);

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //ComboBox.SelectedValue.ToString() returns Id
            var Id = (int)productComboBox.SelectedValue;
            ValidateQuantity(Id);
        }

        private void ValidateQuantity(int Id)
        {
            try
            {
                if (customerTxt.Text.Length < 3)
                {
                    MessageBox.Show("Customer's name should consist of at least 3 letters");
                    return;
                }
                var quantity = int.Parse(quantityTxt.Text);

                var dbQuantity = ProductDal.DbQuantity(Id);

                if (quantity > dbQuantity)
                {
                    MessageBox.Show($"Sorry. But there exists only {dbQuantity} Quantity of the selected Product.");
                    return;
                }

                if (dbQuantity < 5)
                {
                    var dialogResult = MessageBox.Show("Only limited stock remaining. Plear Re-Order this product", "Limited Stock!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var rol =new ReOrder();
                        rol.Show();
                        Hide();
                    }
                    else
                    {
                        return;
                    }
                    return;
                }

                else
                {
                    var newQuantity = dbQuantity - quantity;


                    //Update Product
                    ProductDal.UpdateExportRecord(Id, newQuantity);

                    var product = ProductDal.GetProduct(Id);
                    product.Quantity = quantity; //Override

                    //Update Recent Transaction
                    ProductDal.UpdateRecentTransaction("Export", product);

                    MessageBox.Show("Succesfully recorded the export transaction");
                    this.Close();

                    BaseDAL.showDashboard();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Quantity's " + e.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseDAL.showDashboard();
        }

        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

    }
}
