namespace KP_bicycle_store
{
    partial class AdminOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrdersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bikePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ClientsFormButton = new System.Windows.Forms.Button();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.EditButtonButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BicycleOrderTable = new System.Windows.Forms.DataGridView();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.userPicture);
            this.panel1.Controls.Add(this.bikePicture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 69);
            this.panel1.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Gray;
            this.ExitButton.Location = new System.Drawing.Point(1188, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 25);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // userPicture
            // 
            this.userPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.Image = global::KP_bicycle_store.Properties.Resources.admin;
            this.userPicture.Location = new System.Drawing.Point(1152, 12);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(50, 50);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 16;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.UserPicture_Click);
            // 
            // bikePicture
            // 
            this.bikePicture.BackColor = System.Drawing.Color.Transparent;
            this.bikePicture.Image = global::KP_bicycle_store.Properties.Resources.bicycle;
            this.bikePicture.Location = new System.Drawing.Point(12, 12);
            this.bikePicture.Name = "bikePicture";
            this.bikePicture.Size = new System.Drawing.Size(50, 50);
            this.bikePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bikePicture.TabIndex = 12;
            this.bikePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1214, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "BICYCLES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.Gray;
            this.menuPanel.Controls.Add(this.ClientsFormButton);
            this.menuPanel.Controls.Add(this.MainFormButton);
            this.menuPanel.Controls.Add(this.EditButtonButton);
            this.menuPanel.Controls.Add(this.LogOutButton);
            this.menuPanel.Location = new System.Drawing.Point(1061, 72);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(141, 170);
            this.menuPanel.TabIndex = 46;
            this.menuPanel.Visible = false;
            // 
            // ClientsFormButton
            // 
            this.ClientsFormButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClientsFormButton.BackColor = System.Drawing.Color.Black;
            this.ClientsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientsFormButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClientsFormButton.ForeColor = System.Drawing.Color.Gray;
            this.ClientsFormButton.Location = new System.Drawing.Point(8, 44);
            this.ClientsFormButton.Name = "ClientsFormButton";
            this.ClientsFormButton.Size = new System.Drawing.Size(125, 35);
            this.ClientsFormButton.TabIndex = 13;
            this.ClientsFormButton.Text = "Clients";
            this.ClientsFormButton.UseVisualStyleBackColor = false;
            this.ClientsFormButton.Click += new System.EventHandler(this.ClientsFormButton_Click);
            // 
            // MainFormButton
            // 
            this.MainFormButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainFormButton.BackColor = System.Drawing.Color.Black;
            this.MainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainFormButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainFormButton.ForeColor = System.Drawing.Color.Gray;
            this.MainFormButton.Location = new System.Drawing.Point(8, 3);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(125, 35);
            this.MainFormButton.TabIndex = 12;
            this.MainFormButton.Text = "Main Form";
            this.MainFormButton.UseVisualStyleBackColor = false;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // EditButtonButton
            // 
            this.EditButtonButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditButtonButton.BackColor = System.Drawing.Color.Black;
            this.EditButtonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButtonButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditButtonButton.ForeColor = System.Drawing.Color.Gray;
            this.EditButtonButton.Location = new System.Drawing.Point(8, 85);
            this.EditButtonButton.Name = "EditButtonButton";
            this.EditButtonButton.Size = new System.Drawing.Size(125, 35);
            this.EditButtonButton.TabIndex = 9;
            this.EditButtonButton.Text = "Edit Info";
            this.EditButtonButton.UseVisualStyleBackColor = false;
            this.EditButtonButton.Click += new System.EventHandler(this.EditButtonButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LogOutButton.ForeColor = System.Drawing.Color.Gray;
            this.LogOutButton.Location = new System.Drawing.Point(8, 126);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(125, 35);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BicycleOrderTable
            // 
            this.BicycleOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BicycleOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BicycleOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bicycle_order_id,
            this.bicycle_id,
            this.quantity,
            this.price,
            this.order_id});
            this.BicycleOrderTable.Location = new System.Drawing.Point(8, 75);
            this.BicycleOrderTable.Name = "BicycleOrderTable";
            this.BicycleOrderTable.RowTemplate.Height = 24;
            this.BicycleOrderTable.Size = new System.Drawing.Size(727, 683);
            this.BicycleOrderTable.TabIndex = 47;
            // 
            // OrderTable
            // 
            this.OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.client_id,
            this.dataGridViewTextBoxColumn4});
            this.OrderTable.Location = new System.Drawing.Point(741, 75);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowTemplate.Height = 24;
            this.OrderTable.Size = new System.Drawing.Size(458, 683);
            this.OrderTable.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // client_id
            // 
            this.client_id.HeaderText = "client_id";
            this.client_id.Name = "client_id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bicycle_order_id
            // 
            this.bicycle_order_id.HeaderText = "bicycle_order_id";
            this.bicycle_order_id.Name = "bicycle_order_id";
            // 
            // bicycle_id
            // 
            this.bicycle_id.HeaderText = "bicycle_id";
            this.bicycle_id.Name = "bicycle_id";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // order_id
            // 
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1214, 770);
            this.Controls.Add(this.BicycleOrderTable);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BicycleOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox bikePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button EditButtonButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ClientsFormButton;
        private System.Windows.Forms.DataGridView BicycleOrderTable;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
    }
}