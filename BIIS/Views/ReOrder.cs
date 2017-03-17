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

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Hide();
            BusinessLogics.BaseDAL.showDashboard();
        }

        private void ReOrder_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIISDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.bIISDataSet1.Product);
        }

        private void metroTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

            MessageBox.Show("Succesfully Ordered!");
            Hide();
            BaseDAL.showDashboard();
        }
    }
}
