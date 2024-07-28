namespace Hotel
{
    partial class Autentification_form
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
            this.Entrance_button = new System.Windows.Forms.Button();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrance_button
            // 
            this.Entrance_button.Location = new System.Drawing.Point(12, 12);
            this.Entrance_button.Name = "Entrance_button";
            this.Entrance_button.Size = new System.Drawing.Size(212, 48);
            this.Entrance_button.TabIndex = 0;
            this.Entrance_button.Text = "Вход";
            this.Entrance_button.UseVisualStyleBackColor = true;
            this.Entrance_button.Click += new System.EventHandler(this.Entrance_button_Click);
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(251, 12);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(212, 48);
            this.Registration_button.TabIndex = 1;
            this.Registration_button.Text = "Регистрация";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(297, 89);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(166, 53);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Autentification_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 157);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.Entrance_button);
            this.Name = "Autentification_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentification Form";
            this.Load += new System.EventHandler(this.Autentification_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Entrance_button;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Button Close_button;
    }
}

