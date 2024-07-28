namespace Hotel
{
    partial class Admins_Autentification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admins_Autentification));
            this.Back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autentificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.autentificationTableAdapter = new Hotel.HotelDataSetTableAdapters.AutentificationTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.Notice_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Perm_textBox = new System.Windows.Forms.TextBox();
            this.Perm_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(653, 382);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 9;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.permissionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autentificationBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 429);
            this.dataGridView1.TabIndex = 10;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 58;
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "Permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            this.permissionDataGridViewTextBoxColumn.Width = 82;
            // 
            // autentificationBindingSource
            // 
            this.autentificationBindingSource.DataMember = "Autentification";
            this.autentificationBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autentificationTableAdapter
            // 
            this.autentificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutentificationTableAdapter = this.autentificationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Order_StatusTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.Room_StatusTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.SettlementTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Notice_label
            // 
            this.Notice_label.AutoSize = true;
            this.Notice_label.Location = new System.Drawing.Point(320, 9);
            this.Notice_label.Name = "Notice_label";
            this.Notice_label.Size = new System.Drawing.Size(349, 117);
            this.Notice_label.TabIndex = 11;
            this.Notice_label.Text = resources.GetString("Notice_label.Text");
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(332, 157);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(112, 13);
            this.Login_label.TabIndex = 12;
            this.Login_label.Text = "Логин пользователя\r\n";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(483, 235);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(92, 23);
            this.Confirm_button.TabIndex = 13;
            this.Confirm_button.Text = "Подтвердить";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(475, 150);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(100, 20);
            this.Login_textBox.TabIndex = 14;
            // 
            // Perm_textBox
            // 
            this.Perm_textBox.Location = new System.Drawing.Point(521, 187);
            this.Perm_textBox.Name = "Perm_textBox";
            this.Perm_textBox.Size = new System.Drawing.Size(54, 20);
            this.Perm_textBox.TabIndex = 16;
            // 
            // Perm_label
            // 
            this.Perm_label.AutoSize = true;
            this.Perm_label.Location = new System.Drawing.Point(332, 194);
            this.Perm_label.Name = "Perm_label";
            this.Perm_label.Size = new System.Drawing.Size(178, 13);
            this.Perm_label.TabIndex = 15;
            this.Perm_label.Text = "Новое разрешение пользователя\r\n";
            // 
            // Admins_Autentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Perm_textBox);
            this.Controls.Add(this.Perm_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Notice_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back_button);
            this.Name = "Admins_Autentification";
            this.Text = "Admins_Autentification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admins_Autentification_FormClosing);
            this.Load += new System.EventHandler(this.Admins_Autentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autentificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string Perm;
        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource autentificationBindingSource;
        private HotelDataSetTableAdapters.AutentificationTableAdapter autentificationTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Notice_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Perm_textBox;
        private System.Windows.Forms.Label Perm_label;
    }
}