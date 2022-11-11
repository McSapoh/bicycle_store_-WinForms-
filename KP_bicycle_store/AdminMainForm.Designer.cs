namespace KP_bicycle_store
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.bikePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BicyclesTable = new System.Windows.Forms.DataGridView();
            this.bicycle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheel_diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycle_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_name_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_country_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountriesTable = new System.Windows.Forms.DataGridView();
            this.county_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducersTable = new System.Windows.Forms.DataGridView();
            this.producer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypesTable = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.WheelDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BicycleNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountryIdTextBox = new System.Windows.Forms.TextBox();
            this.ProducerIdTextBox = new System.Windows.Forms.TextBox();
            this.TypeIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BicycleIdLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ClientsFormButton = new System.Windows.Forms.Button();
            this.OrdersFormButton = new System.Windows.Forms.Button();
            this.EditButtonButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BicyclesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProducersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesTable)).BeginInit();
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
            this.panel1.TabIndex = 9;
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
            // BicyclesTable
            // 
            this.BicyclesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BicyclesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BicyclesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bicycle_id,
            this.bicycle_name,
            this.wheel_diameter,
            this.price,
            this.quantity,
            this.bicycle_type_id,
            this.producer_name_id,
            this.producer_country_id});
            this.BicyclesTable.Location = new System.Drawing.Point(12, 394);
            this.BicyclesTable.Name = "BicyclesTable";
            this.BicyclesTable.RowTemplate.Height = 24;
            this.BicyclesTable.Size = new System.Drawing.Size(1188, 358);
            this.BicyclesTable.TabIndex = 11;
            this.BicyclesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BicyclesTable_CellClick);
            // 
            // bicycle_id
            // 
            this.bicycle_id.HeaderText = "bicycle_id";
            this.bicycle_id.Name = "bicycle_id";
            // 
            // bicycle_name
            // 
            this.bicycle_name.HeaderText = "bicycle_name";
            this.bicycle_name.Name = "bicycle_name";
            // 
            // wheel_diameter
            // 
            this.wheel_diameter.HeaderText = "wheel_diameter";
            this.wheel_diameter.Name = "wheel_diameter";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // bicycle_type_id
            // 
            this.bicycle_type_id.HeaderText = "bicycle_type_id";
            this.bicycle_type_id.Name = "bicycle_type_id";
            // 
            // producer_name_id
            // 
            this.producer_name_id.HeaderText = "producer_name_id";
            this.producer_name_id.Name = "producer_name_id";
            // 
            // producer_country_id
            // 
            this.producer_country_id.HeaderText = "producer_country_id";
            this.producer_country_id.Name = "producer_country_id";
            // 
            // CountriesTable
            // 
            this.CountriesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CountriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountriesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.county_id,
            this.country_name});
            this.CountriesTable.Location = new System.Drawing.Point(987, 75);
            this.CountriesTable.Name = "CountriesTable";
            this.CountriesTable.RowTemplate.Height = 24;
            this.CountriesTable.Size = new System.Drawing.Size(213, 313);
            this.CountriesTable.TabIndex = 12;
            // 
            // county_id
            // 
            this.county_id.HeaderText = "id";
            this.county_id.Name = "county_id";
            // 
            // country_name
            // 
            this.country_name.HeaderText = "country_name";
            this.country_name.Name = "country_name";
            // 
            // ProducersTable
            // 
            this.ProducersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProducersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProducersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producer_id,
            this.producer_name});
            this.ProducersTable.Location = new System.Drawing.Point(768, 75);
            this.ProducersTable.Name = "ProducersTable";
            this.ProducersTable.RowTemplate.Height = 24;
            this.ProducersTable.Size = new System.Drawing.Size(213, 313);
            this.ProducersTable.TabIndex = 13;
            // 
            // producer_id
            // 
            this.producer_id.HeaderText = "id";
            this.producer_id.Name = "producer_id";
            // 
            // producer_name
            // 
            this.producer_name.HeaderText = "producer_name";
            this.producer_name.Name = "producer_name";
            // 
            // TypesTable
            // 
            this.TypesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TypesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_id,
            this.type_name});
            this.TypesTable.Location = new System.Drawing.Point(549, 75);
            this.TypesTable.Name = "TypesTable";
            this.TypesTable.RowTemplate.Height = 24;
            this.TypesTable.Size = new System.Drawing.Size(213, 313);
            this.TypesTable.TabIndex = 14;
            // 
            // type_id
            // 
            this.type_id.HeaderText = "id";
            this.type_id.Name = "type_id";
            // 
            // type_name
            // 
            this.type_name.HeaderText = "type_name";
            this.type_name.Name = "type_name";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.QuantityTextBox.Location = new System.Drawing.Point(12, 351);
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(260, 35);
            this.QuantityTextBox.TabIndex = 26;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.PriceTextBox.Location = new System.Drawing.Point(12, 271);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(260, 35);
            this.PriceTextBox.TabIndex = 25;
            // 
            // WheelDiameterTextBox
            // 
            this.WheelDiameterTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.WheelDiameterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WheelDiameterTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.WheelDiameterTextBox.Location = new System.Drawing.Point(12, 187);
            this.WheelDiameterTextBox.Multiline = true;
            this.WheelDiameterTextBox.Name = "WheelDiameterTextBox";
            this.WheelDiameterTextBox.Size = new System.Drawing.Size(260, 35);
            this.WheelDiameterTextBox.TabIndex = 24;
            // 
            // BicycleNameTextBox
            // 
            this.BicycleNameTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.BicycleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BicycleNameTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.BicycleNameTextBox.Location = new System.Drawing.Point(12, 105);
            this.BicycleNameTextBox.Multiline = true;
            this.BicycleNameTextBox.Name = "BicycleNameTextBox";
            this.BicycleNameTextBox.Size = new System.Drawing.Size(260, 35);
            this.BicycleNameTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label8.Location = new System.Drawing.Point(7, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label7.Location = new System.Drawing.Point(7, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Wheel Diameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bicycle Name";
            // 
            // CountryIdTextBox
            // 
            this.CountryIdTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.CountryIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.CountryIdTextBox.Location = new System.Drawing.Point(283, 271);
            this.CountryIdTextBox.Multiline = true;
            this.CountryIdTextBox.Name = "CountryIdTextBox";
            this.CountryIdTextBox.Size = new System.Drawing.Size(260, 35);
            this.CountryIdTextBox.TabIndex = 34;
            // 
            // ProducerIdTextBox
            // 
            this.ProducerIdTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.ProducerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProducerIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ProducerIdTextBox.Location = new System.Drawing.Point(283, 187);
            this.ProducerIdTextBox.Multiline = true;
            this.ProducerIdTextBox.Name = "ProducerIdTextBox";
            this.ProducerIdTextBox.Size = new System.Drawing.Size(260, 35);
            this.ProducerIdTextBox.TabIndex = 33;
            // 
            // TypeIdTextBox
            // 
            this.TypeIdTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.TypeIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeIdTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.TypeIdTextBox.Location = new System.Drawing.Point(283, 105);
            this.TypeIdTextBox.Multiline = true;
            this.TypeIdTextBox.Name = "TypeIdTextBox";
            this.TypeIdTextBox.Size = new System.Drawing.Size(260, 35);
            this.TypeIdTextBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(278, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Country Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(278, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "Producer Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(278, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "Type Id";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Black;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ResetButton.ForeColor = System.Drawing.Color.Gray;
            this.ResetButton.Location = new System.Drawing.Point(283, 352);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 35);
            this.ResetButton.TabIndex = 39;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SaveButton.ForeColor = System.Drawing.Color.Gray;
            this.SaveButton.Location = new System.Drawing.Point(283, 312);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(260, 35);
            this.SaveButton.TabIndex = 40;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Gray;
            this.DeleteButton.Location = new System.Drawing.Point(418, 353);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 35);
            this.DeleteButton.TabIndex = 41;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BicycleIdLabel
            // 
            this.BicycleIdLabel.AutoSize = true;
            this.BicycleIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.BicycleIdLabel.Location = new System.Drawing.Point(248, 75);
            this.BicycleIdLabel.Name = "BicycleIdLabel";
            this.BicycleIdLabel.Size = new System.Drawing.Size(0, 27);
            this.BicycleIdLabel.TabIndex = 43;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.Gray;
            this.menuPanel.Controls.Add(this.ClientsFormButton);
            this.menuPanel.Controls.Add(this.OrdersFormButton);
            this.menuPanel.Controls.Add(this.EditButtonButton);
            this.menuPanel.Controls.Add(this.LogOutButton);
            this.menuPanel.Location = new System.Drawing.Point(1059, 68);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(141, 170);
            this.menuPanel.TabIndex = 44;
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
            this.ClientsFormButton.TabIndex = 12;
            this.ClientsFormButton.Text = "Clients";
            this.ClientsFormButton.UseVisualStyleBackColor = false;
            this.ClientsFormButton.Click += new System.EventHandler(this.ClientsFormButton_Click);
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
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1214, 770);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.BicycleIdLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CountryIdTextBox);
            this.Controls.Add(this.ProducerIdTextBox);
            this.Controls.Add(this.TypeIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.WheelDiameterTextBox);
            this.Controls.Add(this.BicycleNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypesTable);
            this.Controls.Add(this.ProducersTable);
            this.Controls.Add(this.CountriesTable);
            this.Controls.Add(this.BicyclesTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BicyclesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProducersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesTable)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bikePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.DataGridView BicyclesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheel_diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycle_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_name_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_country_id;
        private System.Windows.Forms.DataGridView CountriesTable;
        private System.Windows.Forms.DataGridView ProducersTable;
        private System.Windows.Forms.DataGridView TypesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn county_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox WheelDiameterTextBox;
        private System.Windows.Forms.TextBox BicycleNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountryIdTextBox;
        private System.Windows.Forms.TextBox ProducerIdTextBox;
        private System.Windows.Forms.TextBox TypeIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label BicycleIdLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button OrdersFormButton;
        private System.Windows.Forms.Button EditButtonButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ClientsFormButton;
    }
}