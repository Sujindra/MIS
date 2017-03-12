using BIIS.BusinessLogics;
using System;

namespace BIIS.Views
{
    public partial class RecentTransactions : MetroFramework.Forms.MetroForm
    {
        public RecentTransactions()
        {
            InitializeComponent();
        }

        private void RecentTransactions_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            recentTransactionDataGridView.DataSource = ProductDal.GetAllRecent();
        }
    }
}
