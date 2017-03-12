using BIIS.BusinessLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BIIS.Views
{
    public partial class EditTransactions : MetroFramework.Forms.MetroForm
    {
        public EditTransactions()
        {
            InitializeComponent();
            AcceptButton = updateButton;
        }

        private void EditTransactions_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            editGridView.DataSource = ProductDal.GetAll();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var data = (DataTable)editGridView.DataSource;
            ProductDal.UpdateTable(data);
            MessageBox.Show("Succesfully Updated");
        }
    }
}
