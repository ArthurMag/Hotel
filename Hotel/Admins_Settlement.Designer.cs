namespace Hotel
{
    partial class Admins_Settlement
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
            this.Settlement_dataGridView = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.settlementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settlementTableAdapter = new Hotel.HotelDataSetTableAdapters.SettlementTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.settlementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofsettlementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notice_label = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.SettlementID_label = new System.Windows.Forms.Label();
            this.SettlementID_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Settlement_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).BeginInit();
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
            // Settlement_dataGridView
            // 
            this.Settlement_dataGridView.AllowUserToAddRows = false;
            this.Settlement_dataGridView.AllowUserToDeleteRows = false;
            this.Settlement_dataGridView.AutoGenerateColumns = false;
            this.Settlement_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Settlement_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settlementIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.dateofsettlementDataGridViewTextBoxColumn,
            this.dateofdepartureDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn});
            this.Settlement_dataGridView.DataSource = this.settlementBindingSource;
            this.Settlement_dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.Settlement_dataGridView.Location = new System.Drawing.Point(3, 93);
            this.Settlement_dataGridView.Name = "Settlement_dataGridView";
            this.Settlement_dataGridView.ReadOnly = true;
            this.Settlement_dataGridView.Size = new System.Drawing.Size(644, 345);
            this.Settlement_dataGridView.TabIndex = 10;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // settlementBindingSource
            // 
            this.settlementBindingSource.DataMember = "Settlement";
            this.settlementBindingSource.DataSource = this.hotelDataSet;
            // 
            // settlementTableAdapter
            // 
            this.settlementTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SettlementTableAdapter = this.settlementTableAdapter;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // dateofsettlementDataGridViewTextBoxColumn
            // 
            this.dateofsettlementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofsettlementDataGridViewTextBoxColumn.DataPropertyName = "Date_of_settlement";
            this.dateofsettlementDataGridViewTextBoxColumn.HeaderText = "Date_of_settlement";
            this.dateofsettlementDataGridViewTextBoxColumn.Name = "dateofsettlementDataGridViewTextBoxColumn";
            this.dateofsettlementDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofsettlementDataGridViewTextBoxColumn.Width = 124;
            // 
            // dateofdepartureDataGridViewTextBoxColumn
            // 
            this.dateofdepartureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofdepartureDataGridViewTextBoxColumn.DataPropertyName = "Date_of_departure";
            this.dateofdepartureDataGridViewTextBoxColumn.HeaderText = "Date_of_departure";
            this.dateofdepartureDataGridViewTextBoxColumn.Name = "dateofdepartureDataGridViewTextBoxColumn";
            this.dateofdepartureDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofdepartureDataGridViewTextBoxColumn.Width = 121;
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Part";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            this.partDataGridViewTextBoxColumn.ReadOnly = true;
            this.partDataGridViewTextBoxColumn.Width = 51;
            // 
            // Notice_label
            // 
            this.Notice_label.AutoSize = true;
            this.Notice_label.Location = new System.Drawing.Point(0, 9);
            this.Notice_label.Name = "Notice_label";
            this.Notice_label.Size = new System.Drawing.Size(387, 26);
            this.Notice_label.TabIndex = 11;
            this.Notice_label.Text = "Здесь Вы можете установить Date_of_departure  для таблицы Поселения\r\nДата устанав" +
    "ливается автоматически как сегодняшнее число, месяц, год";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(679, 93);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(98, 33);
            this.Confirm_button.TabIndex = 12;
            this.Confirm_button.Text = "Подтвердить";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // SettlementID_label
            // 
            this.SettlementID_label.AutoSize = true;
            this.SettlementID_label.Location = new System.Drawing.Point(579, 40);
            this.SettlementID_label.Name = "SettlementID_label";
            this.SettlementID_label.Size = new System.Drawing.Size(68, 13);
            this.SettlementID_label.TabIndex = 13;
            this.SettlementID_label.Text = "SettlementID";
            // 
            // SettlementID_textBox
            // 
            this.SettlementID_textBox.Location = new System.Drawing.Point(679, 32);
            this.SettlementID_textBox.Name = "SettlementID_textBox";
            this.SettlementID_textBox.Size = new System.Drawing.Size(100, 20);
            this.SettlementID_textBox.TabIndex = 14;
            // 
            // Admins_Settlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettlementID_textBox);
            this.Controls.Add(this.SettlementID_label);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.Notice_label);
            this.Controls.Add(this.Settlement_dataGridView);
            this.Controls.Add(this.Back_button);
            this.Name = "Admins_Settlement";
            this.Text = "Admins_Settlement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admins_Settlement_FormClosing);
            this.Load += new System.EventHandler(this.Admins_Settlement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Settlement_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Settlement_dataGridView;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource settlementBindingSource;
        private HotelDataSetTableAdapters.SettlementTableAdapter settlementTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofsettlementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Notice_label;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Label SettlementID_label;
        private System.Windows.Forms.TextBox SettlementID_textBox;
    }
}