namespace KP_bicycle_store
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 69);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Gray;
            this.ExitButton.Location = new System.Drawing.Point(374, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 25);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameTextBox.Location = new System.Drawing.Point(8, 114);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(380, 35);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TabStop = false;
            this.UsernameTextBox.Text = "Введіть ім\'я користувача";
            this.UsernameTextBox.WordWrap = false;
            this.UsernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label3.Location = new System.Drawing.Point(2, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 204);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(380, 35);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.Text = "Введіть пароль";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(76, 289);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(241, 22);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Don`t have account? Register";
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            this.RegisterButton.MouseLeave += new System.EventHandler(this.RegisterButton_MouseLeave);
            this.RegisterButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterButton_MouseMove);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogInButton.BackColor = System.Drawing.Color.Black;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LogInButton.ForeColor = System.Drawing.Color.Gray;
            this.LogInButton.Location = new System.Drawing.Point(133, 251);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(125, 35);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label RegisterButton;
        private System.Windows.Forms.Button LogInButton;
    }
}

