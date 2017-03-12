using System;
using System.Drawing;
using System.Windows.Forms;

namespace BIIS.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            foreach (var control in this.Controls)
            {
                BackColor = Color.White;
                var client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                    break;
                }
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void exitTile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            var receive = new Receive();
            receive.Show();
            this.Hide();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var export = new Export();
            export.Show();
            this.Hide();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            var inventory = new Inventory();
            inventory.MdiParent = this;
            inventory.Show();
        }

        private void recentButton_Click(object sender, EventArgs e)
        {
            var recent = new RecentTransactions();
            recent.MdiParent = this;
            recent.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var edit = new EditTransactions();
            edit.MdiParent = this;
            edit.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
