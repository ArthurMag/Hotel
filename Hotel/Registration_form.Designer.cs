namespace Hotel
{
    partial class Registration_form
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Login_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(182, 111);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(123, 27);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Отмена";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(32, 111);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(125, 27);
            this.Registration_button.TabIndex = 1;
            this.Registration_button.Text = "Зарегистрироваться";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(57, 24);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(33, 13);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "Login";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(172, 24);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(100, 20);
            this.Login_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(172, 63);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(100, 20);
            this.Password_textBox.TabIndex = 5;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(57, 63);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 151);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.Back_button);
            this.Name = "Registration_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password_label;
    }
}