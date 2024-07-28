namespace Hotel
{
    partial class Make_A_Request
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
            this.ServicesGridView = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new Hotel.HotelDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.servicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_name_label = new System.Windows.Forms.Label();
            this.Service_name_textBox = new System.Windows.Forms.TextBox();
            this.Your_room_number_textBox = new System.Windows.Forms.TextBox();
            this.Your_room_number_label = new System.Windows.Forms.Label();
            this.Make_a_request_button = new System.Windows.Forms.Button();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Amount_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(653, 382);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ServicesGridView
            // 
            this.ServicesGridView.AllowUserToAddRows = false;
            this.ServicesGridView.AllowUserToDeleteRows = false;
            this.ServicesGridView.AutoGenerateColumns = false;
            this.ServicesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ServicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicenameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.ServicesGridView.DataSource = this.servicesBindingSource;
            this.ServicesGridView.Location = new System.Drawing.Point(-1, 194);
            this.ServicesGridView.Name = "ServicesGridView";
            this.ServicesGridView.ReadOnly = true;
            this.ServicesGridView.Size = new System.Drawing.Size(648, 244);
            this.ServicesGridView.TabIndex = 5;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotelDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.SettlementTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicenameDataGridViewTextBoxColumn
            // 
            this.servicenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.servicenameDataGridViewTextBoxColumn.DataPropertyName = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.HeaderText = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.Name = "servicenameDataGridViewTextBoxColumn";
            this.servicenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicenameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // Service_name_label
            // 
            this.Service_name_label.AutoSize = true;
            this.Service_name_label.Location = new System.Drawing.Point(22, 69);
            this.Service_name_label.Name = "Service_name_label";
            this.Service_name_label.Size = new System.Drawing.Size(93, 13);
            this.Service_name_label.TabIndex = 6;
            this.Service_name_label.Text = "Название услуги";
            // 
            // Service_name_textBox
            // 
            this.Service_name_textBox.Location = new System.Drawing.Point(152, 62);
            this.Service_name_textBox.Name = "Service_name_textBox";
            this.Service_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Service_name_textBox.TabIndex = 7;
            // 
            // Your_room_number_textBox
            // 
            this.Your_room_number_textBox.Location = new System.Drawing.Point(152, 100);
            this.Your_room_number_textBox.Name = "Your_room_number_textBox";
            this.Your_room_number_textBox.Size = new System.Drawing.Size(100, 20);
            this.Your_room_number_textBox.TabIndex = 9;
            // 
            // Your_room_number_label
            // 
            this.Your_room_number_label.AutoSize = true;
            this.Your_room_number_label.Location = new System.Drawing.Point(22, 100);
            this.Your_room_number_label.Name = "Your_room_number_label";
            this.Your_room_number_label.Size = new System.Drawing.Size(124, 13);
            this.Your_room_number_label.TabIndex = 8;
            this.Your_room_number_label.Text = "Номер вашей комнаты";
            // 
            // Make_a_request_button
            // 
            this.Make_a_request_button.Location = new System.Drawing.Point(320, 91);
            this.Make_a_request_button.Name = "Make_a_request_button";
            this.Make_a_request_button.Size = new System.Drawing.Size(90, 31);
            this.Make_a_request_button.TabIndex = 10;
            this.Make_a_request_button.Text = "Сделать заказ";
            this.Make_a_request_button.UseVisualStyleBackColor = true;
            this.Make_a_request_button.Click += new System.EventHandler(this.Make_a_request_button_Click);
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(152, 138);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(100, 20);
            this.Amount_textBox.TabIndex = 12;
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(22, 138);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(96, 13);
            this.Amount_label.TabIndex = 11;
            this.Amount_label.Text = "Количество услуг";
            // 
            // Make_A_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Amount_textBox);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Make_a_request_button);
            this.Controls.Add(this.Your_room_number_textBox);
            this.Controls.Add(this.Your_room_number_label);
            this.Controls.Add(this.Service_name_textBox);
            this.Controls.Add(this.Service_name_label);
            this.Controls.Add(this.ServicesGridView);
            this.Controls.Add(this.Back_button);
            this.Name = "Make_A_Request";
            this.Text = "Make_A_Request";
            this.Load += new System.EventHandler(this.Make_A_Request_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView ServicesGridView;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HotelDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Service_name_label;
        private System.Windows.Forms.TextBox Service_name_textBox;
        private System.Windows.Forms.TextBox Your_room_number_textBox;
        private System.Windows.Forms.Label Your_room_number_label;
        private System.Windows.Forms.Button Make_a_request_button;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.Label Amount_label;
    }
}