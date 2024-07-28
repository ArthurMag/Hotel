namespace Hotel
{
    partial class Personal_Data
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
            this.Change_Your_Data_Button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Patronym_textBox = new System.Windows.Forms.TextBox();
            this.Patronym_label = new System.Windows.Forms.Label();
            this.First_Name_textBox = new System.Windows.Forms.TextBox();
            this.First_Name_label = new System.Windows.Forms.Label();
            this.Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Change_Your_Data_Button
            // 
            this.Change_Your_Data_Button.Location = new System.Drawing.Point(13, 272);
            this.Change_Your_Data_Button.Name = "Change_Your_Data_Button";
            this.Change_Your_Data_Button.Size = new System.Drawing.Size(156, 56);
            this.Change_Your_Data_Button.TabIndex = 0;
            this.Change_Your_Data_Button.Text = "Изменить данные";
            this.Change_Your_Data_Button.UseVisualStyleBackColor = true;
            this.Change_Your_Data_Button.Click += new System.EventHandler(this.Change_Your_Data_Button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(435, 272);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 3;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Patronym_textBox);
            this.panel1.Controls.Add(this.Patronym_label);
            this.panel1.Controls.Add(this.First_Name_textBox);
            this.panel1.Controls.Add(this.First_Name_label);
            this.panel1.Controls.Add(this.Last_Name_textBox);
            this.panel1.Controls.Add(this.Last_name_label);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 254);
            this.panel1.TabIndex = 5;
            // 
            // Patronym_textBox
            // 
            this.Patronym_textBox.Location = new System.Drawing.Point(98, 64);
            this.Patronym_textBox.Name = "Patronym_textBox";
            this.Patronym_textBox.ReadOnly = true;
            this.Patronym_textBox.Size = new System.Drawing.Size(257, 20);
            this.Patronym_textBox.TabIndex = 5;
            // 
            // Patronym_label
            // 
            this.Patronym_label.Location = new System.Drawing.Point(21, 64);
            this.Patronym_label.Name = "Patronym_label";
            this.Patronym_label.Size = new System.Drawing.Size(71, 20);
            this.Patronym_label.TabIndex = 4;
            this.Patronym_label.Text = "Отчество";
            // 
            // First_Name_textBox
            // 
            this.First_Name_textBox.Location = new System.Drawing.Point(98, 38);
            this.First_Name_textBox.Name = "First_Name_textBox";
            this.First_Name_textBox.ReadOnly = true;
            this.First_Name_textBox.Size = new System.Drawing.Size(257, 20);
            this.First_Name_textBox.TabIndex = 3;
            // 
            // First_Name_label
            // 
            this.First_Name_label.Location = new System.Drawing.Point(21, 38);
            this.First_Name_label.Name = "First_Name_label";
            this.First_Name_label.Size = new System.Drawing.Size(71, 20);
            this.First_Name_label.TabIndex = 2;
            this.First_Name_label.Text = "Имя";
            // 
            // Last_Name_textBox
            // 
            this.Last_Name_textBox.Location = new System.Drawing.Point(98, 12);
            this.Last_Name_textBox.Name = "Last_Name_textBox";
            this.Last_Name_textBox.ReadOnly = true;
            this.Last_Name_textBox.Size = new System.Drawing.Size(257, 20);
            this.Last_Name_textBox.TabIndex = 1;
            // 
            // Last_name_label
            // 
            this.Last_name_label.Location = new System.Drawing.Point(21, 12);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(71, 20);
            this.Last_name_label.TabIndex = 0;
            this.Last_name_label.Text = "Фамилия";
            // 
            // Personal_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Change_Your_Data_Button);
            this.Name = "Personal_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_Data_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Data_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public string HashedPass;

        private System.Windows.Forms.Button Change_Your_Data_Button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Patronym_textBox;
        private System.Windows.Forms.Label Patronym_label;
        private System.Windows.Forms.TextBox First_Name_textBox;
        private System.Windows.Forms.Label First_Name_label;
        private System.Windows.Forms.TextBox Last_Name_textBox;
        private System.Windows.Forms.Label Last_name_label;
    }
}