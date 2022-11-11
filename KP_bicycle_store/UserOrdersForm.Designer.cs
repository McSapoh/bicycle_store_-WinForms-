namespace KP_bicycle_store
{
    partial class UserOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrdersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bikePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.MainFormButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BicycleOrderTable = new System.Windows.Forms.DataGridView();
            this.bicycle_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.userButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.bikePicture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 69);
            this.panel1.TabIndex = 9;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Gray;
            this.ExitButton.Location = new System.Drawing.Point(974, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 25);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.Controls.Add(this.userNameLabel);
            this.userButton.Controls.Add(this.userPicture);
            this.userButton.Location = new System.Drawing.Point(755, 12);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(233, 50);
            this.userButton.TabIndex = 14;
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userNameLabel.Location = new System.Drawing.Point(0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(183, 50);
            this.userNameLabel.TabIndex = 12;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.userPicture.Image = global::KP_bicycle_store.Properties.Resources.user;
            this.userPicture.Location = new System.Drawing.Point(183, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(50, 50);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(1000, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "MY ORDERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuPanel.Controls.Add(this.MainFormButton);
            this.menuPanel.Controls.Add(this.EditProfileButton);
            this.menuPanel.Controls.Add(this.LogOutButton);
            this.menuPanel.Location = new System.Drawing.Point(797, 75);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(141, 130);
            this.menuPanel.TabIndex = 11;
            this.menuPanel.Visible = false;
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
            this.MainFormButton.TabIndex = 11;
            this.MainFormButton.Text = "Main Form";
            this.MainFormButton.UseVisualStyleBackColor = false;
            this.MainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditProfileButton.BackColor = System.Drawing.Color.Black;
            this.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProfileButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditProfileButton.ForeColor = System.Drawing.Color.Gray;
            this.EditProfileButton.Location = new System.Drawing.Point(8, 44);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(125, 35);
            this.EditProfileButton.TabIndex = 9;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LogOutButton.ForeColor = System.Drawing.Color.Gray;
            this.LogOutButton.Location = new System.Drawing.Point(8, 85);
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
            this.cost,
            this.order_id});
            this.BicycleOrderTable.Location = new System.Drawing.Point(8, 75);
            this.BicycleOrderTable.Name = "BicycleOrderTable";
            this.BicycleOrderTable.RowTemplate.Height = 24;
            this.BicycleOrderTable.Size = new System.Drawing.Size(980, 613);
            this.BicycleOrderTable.TabIndex = 10;
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
            // cost
            // 
            this.cost.HeaderText = "cost";
            this.cost.Name = "cost";
            // 
            // order_id
            // 
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            // 
            // UserOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.BicycleOrderTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseOrdersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BicycleOrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel userButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox bikePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button MainFormButton;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView BicycleOrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
    }
}