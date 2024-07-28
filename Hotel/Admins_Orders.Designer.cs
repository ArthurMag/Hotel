namespace Hotel
{
    partial class Admins_Orders
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
            this.Orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Hotel.HotelDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.Orders_status_dataGridView = new System.Windows.Forms.DataGridView();
            this.order_StatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_StatusTableAdapter = new Hotel.HotelDataSetTableAdapters.Order_StatusTableAdapter();
            this.orderStatusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notice_label = new System.Windows.Forms.Label();
            this.OrderID_label = new System.Windows.Forms.Label();
            this.OrderID_textBox = new System.Windows.Forms.TextBox();
            this.New_order_status_textBox = new System.Windows.Forms.TextBox();
            this.New_order_status_label = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_status_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_StatusBindingSource)).BeginInit();
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
            // Orders_dataGridView
            // 
            this.Orders_dataGridView.AllowUserToAddRows = false;
            this.Orders_dataGridView.AllowUserToDeleteRows = false;
            this.Orders_dataGridView.AutoGenerateColumns = false;
            this.Orders_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.settlementIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.orderStatusIDDataGridViewTextBoxColumn});
            this.Orders_dataGridView.DataSource = this.ordersBindingSource;
            this.Orders_dataGridView.Location = new System.Drawing.Point(12, 13);
            this.Orders_dataGridView.Name = "Orders_dataGridView";
            this.Orders_dataGridView.ReadOnly = true;
            this.Orders_dataGridView.Size = new System.Drawing.Size(389, 425);
            this.Orders_dataGridView.TabIndex = 10;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.hotelDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Order_StatusTableAdapter = this.order_StatusTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.Room_StatusTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.SettlementTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Orders_status_dataGridView
            // 
            this.Orders_status_dataGridView.AllowUserToAddRows = false;
            this.Orders_status_dataGridView.AllowUserToDeleteRows = false;
            this.Orders_status_dataGridView.AutoGenerateColumns = false;
            this.Orders_status_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Orders_status_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_status_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderStatusIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.Orders_status_dataGridView.DataSource = this.order_StatusBindingSource;
            this.Orders_status_dataGridView.Location = new System.Drawing.Point(407, 288);
            this.Orders_status_dataGridView.Name = "Orders_status_dataGridView";
            this.Orders_status_dataGridView.ReadOnly = true;
            this.Orders_status_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.Orders_status_dataGridView.TabIndex = 11;
            // 
            // order_StatusBindingSource
            // 
            this.order_StatusBindingSource.DataMember = "Order_Status";
            this.order_StatusBindingSource.DataSource = this.hotelDataSet;
            // 
            // order_StatusTableAdapter
            // 
            this.order_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // orderStatusIDDataGridViewTextBoxColumn1
            // 
            this.orderStatusIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderStatusIDDataGridViewTextBoxColumn1.DataPropertyName = "Order_StatusID";
            this.orderStatusIDDataGridViewTextBoxColumn1.HeaderText = "Order_StatusID";
            this.orderStatusIDDataGridViewTextBoxColumn1.Name = "orderStatusIDDataGridViewTextBoxColumn1";
            this.orderStatusIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderStatusIDDataGridViewTextBoxColumn1.Width = 105;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // settlementIDDataGridViewTextBoxColumn
            // 
            this.settlementIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.settlementIDDataGridViewTextBoxColumn.DataPropertyName = "SettlementID";
            this.settlementIDDataGridViewTextBoxColumn.HeaderText = "SettlementID";
            this.settlementIDDataGridViewTextBoxColumn.Name = "settlementIDDataGridViewTextBoxColumn";
            this.settlementIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.settlementIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 79;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 68;
            // 
            // orderStatusIDDataGridViewTextBoxColumn
            // 
            this.orderStatusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Order_StatusID";
            this.orderStatusIDDataGridViewTextBoxColumn.HeaderText = "Order_StatusID";
            this.orderStatusIDDataGridViewTextBoxColumn.Name = "orderStatusIDDataGridViewTextBoxColumn";
            this.orderStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderStatusIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // Notice_label
            // 
            this.Notice_label.AutoSize = true;
            this.Notice_label.Location = new System.Drawing.Point(408, 13);
            this.Notice_label.Name = "Notice_label";
            this.Notice_label.Size = new System.Drawing.Size(185, 13);
            this.Notice_label.TabIndex = 12;
            this.Notice_label.Text = "Вы можете сменить статус заказа";
            // 
            // OrderID_label
            // 
            this.OrderID_label.AutoSize = true;
            this.OrderID_label.Location = new System.Drawing.Point(438, 59);
            this.OrderID_label.Name = "OrderID_label";
            this.OrderID_label.Size = new System.Drawing.Size(80, 13);
            this.OrderID_label.TabIndex = 13;
            this.OrderID_label.Text = "Номер заказа";
            // 
            // OrderID_textBox
            // 
            this.OrderID_textBox.Location = new System.Drawing.Point(574, 56);
            this.OrderID_textBox.Name = "OrderID_textBox";
            this.OrderID_textBox.Size = new System.Drawing.Size(100, 20);
            this.OrderID_textBox.TabIndex = 14;
            // 
            // New_order_status_textBox
            // 
            this.New_order_status_textBox.Location = new System.Drawing.Point(574, 102);
            this.New_order_status_textBox.Name = "New_order_status_textBox";
            this.New_order_status_textBox.Size = new System.Drawing.Size(100, 20);
            this.New_order_status_textBox.TabIndex = 16;
            // 
            // New_order_status_label
            // 
            this.New_order_status_label.AutoSize = true;
            this.New_order_status_label.Location = new System.Drawing.Point(438, 105);
            this.New_order_status_label.Name = "New_order_status_label";
            this.New_order_status_label.Size = new System.Drawing.Size(116, 13);
            this.New_order_status_label.TabIndex = 15;
            this.New_order_status_label.Text = "Новый статус заказа";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(574, 144);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(100, 23);
            this.Confirm_button.TabIndex = 17;
            this.Confirm_button.Text = "Подтвердить";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Admins_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.New_order_status_textBox);
            this.Controls.Add(this.New_order_status_label);
            this.Controls.Add(this.OrderID_textBox);
            this.Controls.Add(this.OrderID_label);
            this.Controls.Add(this.Notice_label);
            this.Controls.Add(this.Orders_status_dataGridView);
            this.Controls.Add(this.Orders_dataGridView);
            this.Controls.Add(this.Back_button);
            this.Name = "Admins_Orders";
            this.Text = "Admins_Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admins_Orders_FormClosing);
            this.Load += new System.EventHandler(this.Admins_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_status_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_StatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Orders_dataGridView;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HotelDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.Order_StatusTableAdapter order_StatusTableAdapter;
        private System.Windows.Forms.DataGridView Orders_status_dataGridView;
        private System.Windows.Forms.BindingSource order_StatusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Notice_label;
        private System.Windows.Forms.Label OrderID_label;
        private System.Windows.Forms.TextBox OrderID_textBox;
        private System.Windows.Forms.TextBox New_order_status_textBox;
        private System.Windows.Forms.Label New_order_status_label;
        private System.Windows.Forms.Button Confirm_button;
    }
}