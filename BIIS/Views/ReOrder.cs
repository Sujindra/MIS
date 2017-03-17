using BIIS.BusinessLogics;
using System;
using System.Windows.Forms;

namespace BIIS.Views
{
    public partial class ReOrder : MetroFramework.Forms.MetroForm
    {
        public ReOrder()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            BaseDAL.showDashboard();
        }

        private void ReOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIISDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.bIISDataSet1.Product);
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var productId = (int)comboBoxProduct.SelectedValue;
            var quantity = Int32.Parse(txtQuantity.Text);

            var previousQuantity = ProductDal.DbQuantity(productId);
            var newQuantity = previousQuantity + quantity;

            //MessageBox.Show($"qty:{quantity} prev:{previousQuantity} new:{newQuantity}");

            ProductDal.ReOrderTransaction(productId, newQuantity);

            var product = ProductDal.GetProduct(productId);
            product.Quantity = quantity;
            ProductDal.UpdateRecentTransaction("Re-Order", product);

            MessageBox.Show("Succesfully Ordered!");
            Hide();
            BaseDAL.showDashboard();
        }
    }
}
