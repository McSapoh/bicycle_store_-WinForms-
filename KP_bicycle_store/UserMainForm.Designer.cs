namespace KP_bicycle_store
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bikePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BicycleTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheel_diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_country_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SaveToOrderButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RemoveFromOrderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.BicycleNameTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.BicycleIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BicycleOrderTable = new System.Windows.Forms.DataGridView();
            this.bicycle_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_bicycles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicyclePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.userButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleTable)).BeginInit();
            this.OrderPanel.SuspendLayout();
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
            this.panel1.TabIndex = 8;
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
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
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
            this.bikePicture.Image = ((System.Drawing.Image)(resources.GetObject("bikePicture.Image")));
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
            this.label1.Text = "BICYCLES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuPanel.Controls.Add(this.OrdersButton);
            this.menuPanel.Controls.Add(this.EditProfileButton);
            this.menuPanel.Controls.Add(this.LogOutButton);
            this.menuPanel.Location = new System.Drawing.Point(797, 72);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(141, 132);
            this.menuPanel.TabIndex = 9;
            this.menuPanel.Visible = false;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrdersButton.BackColor = System.Drawing.Color.Black;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdersButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.OrdersButton.ForeColor = System.Drawing.Color.Gray;
            this.OrdersButton.Location = new System.Drawing.Point(8, 46);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(125, 35);
            this.OrdersButton.TabIndex = 11;
            this.OrdersButton.Text = "My Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditProfileButton.BackColor = System.Drawing.Color.Black;
            this.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProfileButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditProfileButton.ForeColor = System.Drawing.Color.Gray;
            this.EditProfileButton.Location = new System.Drawing.Point(8, 3);
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
            this.LogOutButton.Location = new System.Drawing.Point(8, 87);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(125, 35);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BicycleTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BicycleTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BicycleTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BicycleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BicycleTable.BackgroundColor = System.Drawing.Color.DarkGray;
            this.BicycleTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BicycleTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BicycleTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BicycleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BicycleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BicycleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.wheel_diameter,
            this.price,
            this.quantity,
            this.bicycle_type_name,
            this.producer_name,
            this.producer_country_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BicycleTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.BicycleTable.GridColor = System.Drawing.Color.Black;
            this.BicycleTable.Location = new System.Drawing.Point(12, 345);
            this.BicycleTable.Name = "BicycleTable";
            this.BicycleTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BicycleTable.RowTemplate.Height = 24;
            this.BicycleTable.Size = new System.Drawing.Size(976, 343);
            this.BicycleTable.TabIndex = 10;
            this.BicycleTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BicycleTable_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // wheel_diameter
            // 
            this.wheel_diameter.HeaderText = "Wheel diameter";
            this.wheel_diameter.Name = "wheel_diameter";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // bicycle_type_name
            // 
            this.bicycle_type_name.HeaderText = "Type";
            this.bicycle_type_name.Name = "bicycle_type_name";
            // 
            // producer_name
            // 
            this.producer_name.HeaderText = "Producer";
            this.producer_name.Name = "producer_name";
            // 
            // producer_country_name
            // 
            this.producer_country_name.HeaderText = "Producer country";
            this.producer_country_name.Name = "producer_country_name";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.BackColor = System.Drawing.Color.Black;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.ForeColor = System.Drawing.Color.Gray;
            this.SearchButton.Location = new System.Drawing.Point(699, 304);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 35);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Location = new System.Drawing.Point(488, 304);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(203, 35);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.TabStop = false;
            this.SearchTextBox.Text = "Введіть запит";
            this.SearchTextBox.WordWrap = false;
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmButton.BackColor = System.Drawing.Color.Black;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ConfirmButton.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmButton.Location = new System.Drawing.Point(830, 304);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(158, 35);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm Order";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SaveToOrderButton
            // 
            this.SaveToOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveToOrderButton.BackColor = System.Drawing.Color.Black;
            this.SaveToOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveToOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SaveToOrderButton.ForeColor = System.Drawing.Color.Gray;
            this.SaveToOrderButton.Location = new System.Drawing.Point(12, 72);
            this.SaveToOrderButton.Name = "SaveToOrderButton";
            this.SaveToOrderButton.Size = new System.Drawing.Size(125, 84);
            this.SaveToOrderButton.TabIndex = 14;
            this.SaveToOrderButton.Text = "Save to Order";
            this.SaveToOrderButton.UseVisualStyleBackColor = false;
            this.SaveToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetButton.BackColor = System.Drawing.Color.Black;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ResetButton.ForeColor = System.Drawing.Color.Gray;
            this.ResetButton.Location = new System.Drawing.Point(12, 165);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 84);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset Order";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RemoveFromOrderButton
            // 
            this.RemoveFromOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemoveFromOrderButton.BackColor = System.Drawing.Color.Black;
            this.RemoveFromOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveFromOrderButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.RemoveFromOrderButton.ForeColor = System.Drawing.Color.Gray;
            this.RemoveFromOrderButton.Location = new System.Drawing.Point(12, 255);
            this.RemoveFromOrderButton.Name = "RemoveFromOrderButton";
            this.RemoveFromOrderButton.Size = new System.Drawing.Size(125, 84);
            this.RemoveFromOrderButton.TabIndex = 16;
            this.RemoveFromOrderButton.Text = "Remove From Order";
            this.RemoveFromOrderButton.UseVisualStyleBackColor = false;
            this.RemoveFromOrderButton.Click += new System.EventHandler(this.RemoveFromOrderButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(147, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bicycle id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(147, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bicycle Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(147, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(147, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.CostTextBox);
            this.OrderPanel.Controls.Add(this.BicycleNameTextBox);
            this.OrderPanel.Controls.Add(this.QuantityTextBox);
            this.OrderPanel.Controls.Add(this.PriceTextBox);
            this.OrderPanel.Controls.Add(this.BicycleIdTextBox);
            this.OrderPanel.Location = new System.Drawing.Point(330, 81);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(154, 220);
            this.OrderPanel.TabIndex = 21;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CostTextBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.CostTextBox.ForeColor = System.Drawing.Color.Black;
            this.CostTextBox.Location = new System.Drawing.Point(8, 169);
            this.CostTextBox.Multiline = true;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(139, 40);
            this.CostTextBox.TabIndex = 29;
            this.CostTextBox.TabStop = false;
            this.CostTextBox.WordWrap = false;
            // 
            // BicycleNameTextBox
            // 
            this.BicycleNameTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.BicycleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BicycleNameTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BicycleNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.BicycleNameTextBox.Location = new System.Drawing.Point(8, 40);
            this.BicycleNameTextBox.Multiline = true;
            this.BicycleNameTextBox.Name = "BicycleNameTextBox";
            this.BicycleNameTextBox.ReadOnly = true;
            this.BicycleNameTextBox.Size = new System.Drawing.Size(139, 40);
            this.BicycleNameTextBox.TabIndex = 28;
            this.BicycleNameTextBox.TabStop = false;
            this.BicycleNameTextBox.WordWrap = false;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.QuantityTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuantityTextBox.Location = new System.Drawing.Point(8, 83);
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(139, 40);
            this.QuantityTextBox.TabIndex = 27;
            this.QuantityTextBox.TabStop = false;
            this.QuantityTextBox.WordWrap = false;
            this.QuantityTextBox.Leave += new System.EventHandler(this.QuantityTextBox_Leave);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.PriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.PriceTextBox.Location = new System.Drawing.Point(8, 126);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(139, 40);
            this.PriceTextBox.TabIndex = 26;
            this.PriceTextBox.TabStop = false;
            this.PriceTextBox.WordWrap = false;
            // 
            // BicycleIdTextBox
            // 
            this.BicycleIdTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.BicycleIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BicycleIdTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BicycleIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.BicycleIdTextBox.Location = new System.Drawing.Point(8, -3);
            this.BicycleIdTextBox.Multiline = true;
            this.BicycleIdTextBox.Name = "BicycleIdTextBox";
            this.BicycleIdTextBox.ReadOnly = true;
            this.BicycleIdTextBox.Size = new System.Drawing.Size(139, 40);
            this.BicycleIdTextBox.TabIndex = 25;
            this.BicycleIdTextBox.TabStop = false;
            this.BicycleIdTextBox.WordWrap = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(147, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 40);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cost";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BicycleOrderTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BicycleOrderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BicycleOrderTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BicycleOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BicycleOrderTable.BackgroundColor = System.Drawing.Color.DarkGray;
            this.BicycleOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BicycleOrderTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BicycleOrderTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BicycleOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BicycleOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BicycleOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bicycle_order_id,
            this.bicycle_id,
            this.quantity_bicycles,
            this.bicyclePrice,
            this.cost});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BicycleOrderTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.BicycleOrderTable.GridColor = System.Drawing.Color.Black;
            this.BicycleOrderTable.Location = new System.Drawing.Point(488, 72);
            this.BicycleOrderTable.Name = "BicycleOrderTable";
            this.BicycleOrderTable.RowHeadersWidth = 30;
            this.BicycleOrderTable.RowTemplate.Height = 24;
            this.BicycleOrderTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BicycleOrderTable.Size = new System.Drawing.Size(500, 226);
            this.BicycleOrderTable.TabIndex = 23;
            this.BicycleOrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BicycleOrderTable_CellClick);
            // 
            // bicycle_order_id
            // 
            this.bicycle_order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bicycle_order_id.Frozen = true;
            this.bicycle_order_id.HeaderText = "bc_order_id";
            this.bicycle_order_id.MinimumWidth = 80;
            this.bicycle_order_id.Name = "bicycle_order_id";
            this.bicycle_order_id.Width = 80;
            // 
            // bicycle_id
            // 
            this.bicycle_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bicycle_id.Frozen = true;
            this.bicycle_id.HeaderText = "bicycle_id";
            this.bicycle_id.MinimumWidth = 70;
            this.bicycle_id.Name = "bicycle_id";
            this.bicycle_id.Width = 70;
            // 
            // quantity_bicycles
            // 
            this.quantity_bicycles.HeaderText = "quantity";
            this.quantity_bicycles.MinimumWidth = 50;
            this.quantity_bicycles.Name = "quantity_bicycles";
            // 
            // bicyclePrice
            // 
            this.bicyclePrice.HeaderText = "price";
            this.bicyclePrice.Name = "bicyclePrice";
            // 
            // cost
            // 
            this.cost.HeaderText = "cost";
            this.cost.MinimumWidth = 90;
            this.cost.Name = "cost";
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveFromOrderButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveToOrderButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BicycleTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BicycleOrderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BicycleTable)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BicycleOrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bikePicture;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView BicycleTable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheel_diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_country_name;
        private System.Windows.Forms.Panel userButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Button SaveToOrderButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RemoveFromOrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.TextBox BicycleNameTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox BicycleIdTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BicycleOrderTable;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_bicycles;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicyclePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}