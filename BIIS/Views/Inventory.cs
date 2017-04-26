using BIIS.BusinessLogics;
using System;

namespace BIIS.Views
{
    public partial class Inventory : MetroFramework.Forms.MetroForm
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            inventoryDataGridView.DataSource = ProductDal.GetAll();
            
        }
    }
}
