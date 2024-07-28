namespace Hotel
{
    partial class Secret_And_Cool_Admin
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
            this.GoTo_Autentification_button = new System.Windows.Forms.Button();
            this.GoTo_Staff_button = new System.Windows.Forms.Button();
            this.GoTo_Clients_button = new System.Windows.Forms.Button();
            this.GoTo_Orders_button = new System.Windows.Forms.Button();
            this.GoTo_Settlement_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(653, 382);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // GoTo_Autentification_button
            // 
            this.GoTo_Autentification_button.Location = new System.Drawing.Point(12, 24);
            this.GoTo_Autentification_button.Name = "GoTo_Autentification_button";
            this.GoTo_Autentification_button.Size = new System.Drawing.Size(130, 103);
            this.GoTo_Autentification_button.TabIndex = 9;
            this.GoTo_Autentification_button.Text = "Действия с таблицей Аутентификации";
            this.GoTo_Autentification_button.UseVisualStyleBackColor = true;
            this.GoTo_Autentification_button.Click += new System.EventHandler(this.GoTo_Autentification_button_Click);
            // 
            // GoTo_Staff_button
            // 
            this.GoTo_Staff_button.Location = new System.Drawing.Point(255, 139);
            this.GoTo_Staff_button.Name = "GoTo_Staff_button";
            this.GoTo_Staff_button.Size = new System.Drawing.Size(130, 103);
            this.GoTo_Staff_button.TabIndex = 10;
            this.GoTo_Staff_button.Text = "Действия с таблицей Работников";
            this.GoTo_Staff_button.UseVisualStyleBackColor = true;
            this.GoTo_Staff_button.Visible = false;
            this.GoTo_Staff_button.Click += new System.EventHandler(this.GoTo_Staff_button_Click);
            // 
            // GoTo_Clients_button
            // 
            this.GoTo_Clients_button.Location = new System.Drawing.Point(44, 217);
            this.GoTo_Clients_button.Name = "GoTo_Clients_button";
            this.GoTo_Clients_button.Size = new System.Drawing.Size(130, 103);
            this.GoTo_Clients_button.TabIndex = 11;
            this.GoTo_Clients_button.Text = "Действия с таблицей Клиентов";
            this.GoTo_Clients_button.UseVisualStyleBackColor = true;
            this.GoTo_Clients_button.Visible = false;
            this.GoTo_Clients_button.Click += new System.EventHandler(this.GoTo_Clients_button_Click);
            // 
            // GoTo_Orders_button
            // 
            this.GoTo_Orders_button.Location = new System.Drawing.Point(420, 280);
            this.GoTo_Orders_button.Name = "GoTo_Orders_button";
            this.GoTo_Orders_button.Size = new System.Drawing.Size(130, 103);
            this.GoTo_Orders_button.TabIndex = 12;
            this.GoTo_Orders_button.Text = "Действия с таблицей Заказов";
            this.GoTo_Orders_button.UseVisualStyleBackColor = true;
            this.GoTo_Orders_button.Click += new System.EventHandler(this.GoTo_Orders_button_Click);
            // 
            // GoTo_Settlement_button
            // 
            this.GoTo_Settlement_button.Location = new System.Drawing.Point(574, 39);
            this.GoTo_Settlement_button.Name = "GoTo_Settlement_button";
            this.GoTo_Settlement_button.Size = new System.Drawing.Size(130, 103);
            this.GoTo_Settlement_button.TabIndex = 13;
            this.GoTo_Settlement_button.Text = "Действия с таблицей Поселения";
            this.GoTo_Settlement_button.UseVisualStyleBackColor = true;
            this.GoTo_Settlement_button.Click += new System.EventHandler(this.GoTo_Settlement_button_Click);
            // 
            // Secret_And_Cool_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoTo_Settlement_button);
            this.Controls.Add(this.GoTo_Orders_button);
            this.Controls.Add(this.GoTo_Clients_button);
            this.Controls.Add(this.GoTo_Staff_button);
            this.Controls.Add(this.GoTo_Autentification_button);
            this.Controls.Add(this.Back_button);
            this.Name = "Secret_And_Cool_Admin";
            this.Text = "Secret_And_Cool_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SACA_FormClosing);
            this.Load += new System.EventHandler(this.SACA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private string Pass;
        private string Perm;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button GoTo_Autentification_button;
        private System.Windows.Forms.Button GoTo_Staff_button;
        private System.Windows.Forms.Button GoTo_Clients_button;
        private System.Windows.Forms.Button GoTo_Orders_button;
        private System.Windows.Forms.Button GoTo_Settlement_button;
    }
}