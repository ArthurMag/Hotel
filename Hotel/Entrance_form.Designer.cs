namespace Hotel
{
    partial class Entrance_form
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
            this.Username_label = new System.Windows.Forms.Label();
            this.Entrance_button = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(122, 107);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(16, 37);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(55, 13);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Entrance_button
            // 
            this.Entrance_button.Location = new System.Drawing.Point(19, 107);
            this.Entrance_button.Name = "Entrance_button";
            this.Entrance_button.Size = new System.Drawing.Size(75, 23);
            this.Entrance_button.TabIndex = 2;
            this.Entrance_button.Text = "Вход";
            this.Entrance_button.UseVisualStyleBackColor = true;
            this.Entrance_button.Click += new System.EventHandler(this.Entrance_button_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(16, 69);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(97, 30);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(100, 20);
            this.Username_textBox.TabIndex = 4;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(97, 62);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(100, 20);
            this.Password_textBox.TabIndex = 5;
            // 
            // Entrance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 150);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Entrance_button);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Back_button);
            this.Name = "Entrance_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrance_form";
            this.Load += new System.EventHandler(this.Entrance_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entrance_form_FormClosing);
            
        }

        #endregion
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Button Entrance_button;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        
    }
}