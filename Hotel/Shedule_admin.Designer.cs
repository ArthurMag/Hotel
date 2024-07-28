namespace Hotel
{
    partial class Shedule_admin
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Spec_serv_view = new System.Windows.Forms.DataGridView();
            this.sheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.Date_label = new System.Windows.Forms.Label();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.sheduleTableAdapter = new Hotel.HotelDataSetTableAdapters.SheduleTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.staffTableAdapter = new Hotel.HotelDataSetTableAdapters.StaffTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Shift_label = new System.Windows.Forms.Label();
            this.Shift_textBox = new System.Windows.Forms.TextBox();
            this.StaffID_label = new System.Windows.Forms.Label();
            this.StaffID_textBox = new System.Windows.Forms.TextBox();
            this.Old_StaffID_textBox = new System.Windows.Forms.TextBox();
            this.Old_Info_label = new System.Windows.Forms.Label();
            this.Old_Data_textBox = new System.Windows.Forms.TextBox();
            this.Old_Shift_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(727, 80);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(697, 23);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(107, 50);
            this.Delete_button.TabIndex = 16;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(567, 23);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(107, 50);
            this.Update_button.TabIndex = 15;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(437, 23);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(107, 50);
            this.Insert_button.TabIndex = 14;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Spec_serv_view
            // 
            this.Spec_serv_view.AllowUserToAddRows = false;
            this.Spec_serv_view.AllowUserToDeleteRows = false;
            this.Spec_serv_view.AutoGenerateColumns = false;
            this.Spec_serv_view.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Spec_serv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Spec_serv_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sheduleIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn});
            this.Spec_serv_view.DataSource = this.sheduleBindingSource;
            this.Spec_serv_view.Location = new System.Drawing.Point(-1, 142);
            this.Spec_serv_view.Name = "Spec_serv_view";
            this.Spec_serv_view.ReadOnly = true;
            this.Spec_serv_view.Size = new System.Drawing.Size(444, 239);
            this.Spec_serv_view.TabIndex = 17;
            // 
            // sheduleIDDataGridViewTextBoxColumn
            // 
            this.sheduleIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sheduleIDDataGridViewTextBoxColumn.DataPropertyName = "SheduleID";
            this.sheduleIDDataGridViewTextBoxColumn.HeaderText = "SheduleID";
            this.sheduleIDDataGridViewTextBoxColumn.Name = "sheduleIDDataGridViewTextBoxColumn";
            this.sheduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sheduleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sheduleIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shiftDataGridViewTextBoxColumn.Width = 53;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staffIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // sheduleBindingSource
            // 
            this.sheduleBindingSource.DataMember = "Shedule";
            this.sheduleBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(15, 25);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(33, 13);
            this.Date_label.TabIndex = 19;
            this.Date_label.Text = "Дата";
            // 
            // Date_textBox
            // 
            this.Date_textBox.Location = new System.Drawing.Point(114, 25);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(151, 20);
            this.Date_textBox.TabIndex = 18;
            // 
            // sheduleTableAdapter
            // 
            this.sheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Order_StatusTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.Room_StatusTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.SettlementTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = this.sheduleTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(449, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(413, 239);
            this.dataGridView1.TabIndex = 20;
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            this.staffIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staffIDDataGridViewTextBoxColumn1.Width = 65;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastnameDataGridViewTextBoxColumn.Width = 84;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // patronymDataGridViewTextBoxColumn
            // 
            this.patronymDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patronymDataGridViewTextBoxColumn.DataPropertyName = "Patronym";
            this.patronymDataGridViewTextBoxColumn.HeaderText = "Patronym";
            this.patronymDataGridViewTextBoxColumn.Name = "patronymDataGridViewTextBoxColumn";
            this.patronymDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.patronymDataGridViewTextBoxColumn.Width = 76;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.hotelDataSet;
            // 
            // Shift_label
            // 
            this.Shift_label.AutoSize = true;
            this.Shift_label.Location = new System.Drawing.Point(15, 53);
            this.Shift_label.Name = "Shift_label";
            this.Shift_label.Size = new System.Drawing.Size(40, 13);
            this.Shift_label.TabIndex = 22;
            this.Shift_label.Text = "Смена";
            // 
            // Shift_textBox
            // 
            this.Shift_textBox.Location = new System.Drawing.Point(114, 53);
            this.Shift_textBox.Name = "Shift_textBox";
            this.Shift_textBox.Size = new System.Drawing.Size(151, 20);
            this.Shift_textBox.TabIndex = 21;
            // 
            // StaffID_label
            // 
            this.StaffID_label.AutoSize = true;
            this.StaffID_label.Location = new System.Drawing.Point(15, 80);
            this.StaffID_label.Name = "StaffID_label";
            this.StaffID_label.Size = new System.Drawing.Size(79, 13);
            this.StaffID_label.TabIndex = 24;
            this.StaffID_label.Text = "ID сотрудника";
            // 
            // StaffID_textBox
            // 
            this.StaffID_textBox.Location = new System.Drawing.Point(114, 80);
            this.StaffID_textBox.Name = "StaffID_textBox";
            this.StaffID_textBox.Size = new System.Drawing.Size(151, 20);
            this.StaffID_textBox.TabIndex = 23;
            // 
            // Old_StaffID_textBox
            // 
            this.Old_StaffID_textBox.Location = new System.Drawing.Point(285, 80);
            this.Old_StaffID_textBox.Name = "Old_StaffID_textBox";
            this.Old_StaffID_textBox.Size = new System.Drawing.Size(134, 20);
            this.Old_StaffID_textBox.TabIndex = 27;
            // 
            // Old_Info_label
            // 
            this.Old_Info_label.AutoSize = true;
            this.Old_Info_label.Location = new System.Drawing.Point(274, 9);
            this.Old_Info_label.Name = "Old_Info_label";
            this.Old_Info_label.Size = new System.Drawing.Size(169, 13);
            this.Old_Info_label.TabIndex = 26;
            this.Old_Info_label.Text = "Старая информация для Update";
            // 
            // Old_Data_textBox
            // 
            this.Old_Data_textBox.Location = new System.Drawing.Point(285, 25);
            this.Old_Data_textBox.Name = "Old_Data_textBox";
            this.Old_Data_textBox.Size = new System.Drawing.Size(134, 20);
            this.Old_Data_textBox.TabIndex = 25;
            // 
            // Old_Shift_textBox
            // 
            this.Old_Shift_textBox.Location = new System.Drawing.Point(285, 53);
            this.Old_Shift_textBox.Name = "Old_Shift_textBox";
            this.Old_Shift_textBox.Size = new System.Drawing.Size(134, 20);
            this.Old_Shift_textBox.TabIndex = 29;
            // 
            // Shedule_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 393);
            this.Controls.Add(this.Old_Shift_textBox);
            this.Controls.Add(this.Old_StaffID_textBox);
            this.Controls.Add(this.Old_Info_label);
            this.Controls.Add(this.Old_Data_textBox);
            this.Controls.Add(this.StaffID_label);
            this.Controls.Add(this.StaffID_textBox);
            this.Controls.Add(this.Shift_label);
            this.Controls.Add(this.Shift_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.Spec_serv_view);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Back_button);
            this.Name = "Shedule_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shedule_admn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shedule_admin_FormClosing);
            this.Load += new System.EventHandler(this.Shedule_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Conn;
        private string Pass;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.DataGridView Spec_serv_view;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox Date_textBox;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource sheduleBindingSource;
        private HotelDataSetTableAdapters.SheduleTableAdapter sheduleTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Shift_label;
        private System.Windows.Forms.TextBox Shift_textBox;
        private System.Windows.Forms.Label StaffID_label;
        private System.Windows.Forms.TextBox StaffID_textBox;
        private System.Windows.Forms.TextBox Old_StaffID_textBox;
        private System.Windows.Forms.Label Old_Info_label;
        private System.Windows.Forms.TextBox Old_Data_textBox;
        private System.Windows.Forms.TextBox Old_Shift_textBox;
    }
}