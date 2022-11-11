namespace KP_bicycle_store
{
    partial class AdminClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminClientsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bikePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsTable = new System.Windows.Forms.DataGridView();
            this.client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.OrdersFormButton = new System.Windows.Forms.Button();
            this.EditButtonButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).BeginInit();
            this.menuPanel.SuspendLayout();
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
            // ClientsTable
            // 
            this.ClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_id,
            this.client_name,
            this.phone,
            this.email,
            this.adress,
            this.username,
            this.password});
            this.ClientsTable.Location = new System.Drawing.Point(12, 75);
            this.ClientsTable.Name = "ClientsTable";
            this.ClientsTable.RowTemplate.Height = 24;
            this.ClientsTable.Size = new System.Drawing.Size(1190, 683);
            this.ClientsTable.TabIndex = 12;
            // 
            // client_id
            // 
            this.client_id.HeaderText = "client_id";
            this.client_id.Name = "client_id";
            // 
            // client_name
            // 
            this.client_name.HeaderText = "client_name";
            this.client_name.Name = "client_name";
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // adress
            // 
            this.adress.HeaderText = "adress";
            this.adress.Name = "adress";
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.Gray;
            this.menuPanel.Controls.Add(this.MainFormButton);
            this.menuPanel.Controls.Add(this.OrdersFormButton);
            this.menuPanel.Controls.Add(this.EditButtonButton);
            this.menuPanel.Controls.Add(this.LogOutButton);
            this.menuPanel.Location = new System.Drawing.Point(1061, 68);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(141, 170);
            this.menuPanel.TabIndex = 45;
            this.menuPanel.Visible = false;
            // 
            // MainFormButton
            // 
            this.MainFormButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainFormButton.BackColor = System.Drawing.Color.Black;
            this.MainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainFormButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MainFormButton.ForeColor = System.Drawing.Color.Gray;
            this.MainFormButton.Location = new System.Drawing.Point(8, 44);
            this.MainFormButton.Name = "MainFormButton";
            this.MainFormButton.Size = new System.Drawing.Size(125, 35);
            this.MainFormButton.TabIndex = 12;
            this.MainFormButton.Text = "Main Form";
            this.MainFormButton.UseVisualStyleBackColor = false;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // OrdersFormButton
            // 
            this.OrdersFormButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrdersFormButton.BackColor = System.Drawing.Color.Black;
            this.OrdersFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdersFormButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.OrdersFormButton.ForeColor = System.Drawing.Color.Gray;
            this.OrdersFormButton.Location = new System.Drawing.Point(8, 3);
            this.OrdersFormButton.Name = "OrdersFormButton";
            this.OrdersFormButton.Size = new System.Drawing.Size(125, 35);
            this.OrdersFormButton.TabIndex = 11;
            this.OrdersFormButton.Text = "Orders Form";
            this.OrdersFormButton.UseVisualStyleBackColor = false;
            this.OrdersFormButton.Click += new System.EventHandler(this.OrdersFormButton_Click);
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
            // AdminClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1214, 770);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUsersOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox bikePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button OrdersFormButton;
        private System.Windows.Forms.Button EditButtonButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}