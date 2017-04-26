namespace BIIS.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.recentButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.receiveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.recentButton);
            this.panel1.Controls.Add(this.inventoryButton);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.receiveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 589);
            this.panel1.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.BlueViolet;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(-1, 490);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 98);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.BlueViolet;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editButton.Location = new System.Drawing.Point(0, 392);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(203, 98);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit Transactions";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // recentButton
            // 
            this.recentButton.BackColor = System.Drawing.Color.BlueViolet;
            this.recentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recentButton.FlatAppearance.BorderSize = 0;
            this.recentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recentButton.Location = new System.Drawing.Point(0, 294);
            this.recentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(203, 98);
            this.recentButton.TabIndex = 0;
            this.recentButton.Text = "Recent Transactions";
            this.recentButton.UseVisualStyleBackColor = false;
            this.recentButton.Click += new System.EventHandler(this.recentButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.BlueViolet;
            this.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryButton.Location = new System.Drawing.Point(0, 196);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(203, 98);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Inventory Status";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.BlueViolet;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportButton.Location = new System.Drawing.Point(0, 98);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(203, 98);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export Inventory";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // receiveButton
            // 
            this.receiveButton.BackColor = System.Drawing.Color.BlueViolet;
            this.receiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.receiveButton.FlatAppearance.BorderSize = 0;
            this.receiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveButton.Location = new System.Drawing.Point(0, 0);
            this.receiveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(203, 98);
            this.receiveButton.TabIndex = 0;
            this.receiveButton.Text = "Receive Inventory";
            this.receiveButton.UseVisualStyleBackColor = false;
            this.receiveButton.Click += new System.EventHandler(this.receiveButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 589);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button receiveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button recentButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button exportButton;
    }
}