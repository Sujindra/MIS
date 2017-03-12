using BIIS.BusinessLogics;
using BIIS.Model;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BIIS.Views
{
    public partial class Receive : MetroForm
    {
        public Receive()
        {
            InitializeComponent();
            this.AcceptButton = saveButton;
            this.ControlBox = false; //hides minimize,maximize and exit button
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var newProduct = new Product();
            newProduct.Name = nameTxt.Text;
            newProduct.Type = typeDropDown.Text;
            newProduct.CostPerUnit = Convert.ToInt32(cpuTxt.Text);
            newProduct.Quantity = Convert.ToInt32(quantityTxt.Text);

            ProductDal.SaveNewProduct(newProduct);
            ProductDal.UpdateRecentTransaction("Import",newProduct);

            MessageBox.Show("New Transaction Recorded");

            this.Close();
            BaseDAL.showDashboard();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseDAL.showDashboard();
        }

        private void cpuTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //8equalsBackspace
                e.Handled = true;
        }

        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
