namespace Hotel
{
    partial class Rooms_admin
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
            this.Spec_serv_view = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofpeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comfortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.roomsTableAdapter = new Hotel.HotelDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.Room_number_label = new System.Windows.Forms.Label();
            this.Room_number_textBox = new System.Windows.Forms.TextBox();
            this.Number_of_people_textBox = new System.Windows.Forms.TextBox();
            this.Number_of_people_label = new System.Windows.Forms.Label();
            this.Comfort_textBox = new System.Windows.Forms.TextBox();
            this.Comfort_label = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.Room_StatusID_textBox = new System.Windows.Forms.TextBox();
            this.Room_StatusID_label = new System.Windows.Forms.Label();
            this.Floor_textBox = new System.Windows.Forms.TextBox();
            this.Floor_label = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.Old_room_number_textBox = new System.Windows.Forms.TextBox();
            this.Old_room_number_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomStatusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_StatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_StatusTableAdapter = new Hotel.HotelDataSetTableAdapters.Room_StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_StatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(727, 334);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Spec_serv_view
            // 
            this.Spec_serv_view.AllowUserToAddRows = false;
            this.Spec_serv_view.AllowUserToDeleteRows = false;
            this.Spec_serv_view.AutoGenerateColumns = false;
            this.Spec_serv_view.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Spec_serv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Spec_serv_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomnumberDataGridViewTextBoxColumn,
            this.numberofpeopleDataGridViewTextBoxColumn,
            this.comfortDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.roomStatusIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Spec_serv_view.DataSource = this.roomsBindingSource;
            this.Spec_serv_view.Location = new System.Drawing.Point(1, 193);
            this.Spec_serv_view.Name = "Spec_serv_view";
            this.Spec_serv_view.ReadOnly = true;
            this.Spec_serv_view.Size = new System.Drawing.Size(861, 135);
            this.Spec_serv_view.TabIndex = 5;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomnumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomnumberDataGridViewTextBoxColumn.Width = 101;
            // 
            // numberofpeopleDataGridViewTextBoxColumn
            // 
            this.numberofpeopleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberofpeopleDataGridViewTextBoxColumn.DataPropertyName = "Number_of_people";
            this.numberofpeopleDataGridViewTextBoxColumn.HeaderText = "Number_of_people";
            this.numberofpeopleDataGridViewTextBoxColumn.Name = "numberofpeopleDataGridViewTextBoxColumn";
            this.numberofpeopleDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberofpeopleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberofpeopleDataGridViewTextBoxColumn.Width = 122;
            // 
            // comfortDataGridViewTextBoxColumn
            // 
            this.comfortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comfortDataGridViewTextBoxColumn.DataPropertyName = "Comfort";
            this.comfortDataGridViewTextBoxColumn.HeaderText = "Comfort";
            this.comfortDataGridViewTextBoxColumn.Name = "comfortDataGridViewTextBoxColumn";
            this.comfortDataGridViewTextBoxColumn.ReadOnly = true;
            this.comfortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.comfortDataGridViewTextBoxColumn.Width = 68;
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
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            this.floorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.floorDataGridViewTextBoxColumn.Width = 55;
            // 
            // roomStatusIDDataGridViewTextBoxColumn
            // 
            this.roomStatusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Room_StatusID";
            this.roomStatusIDDataGridViewTextBoxColumn.HeaderText = "Room_StatusID";
            this.roomStatusIDDataGridViewTextBoxColumn.Name = "roomStatusIDDataGridViewTextBoxColumn";
            this.roomStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomStatusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomStatusIDDataGridViewTextBoxColumn.Width = 107;
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
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(437, 23);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(107, 50);
            this.Insert_button.TabIndex = 8;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(567, 23);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(107, 50);
            this.Update_button.TabIndex = 13;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(697, 23);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(107, 50);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.SettlementTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Room_number_label
            // 
            this.Room_number_label.AutoSize = true;
            this.Room_number_label.Location = new System.Drawing.Point(13, 23);
            this.Room_number_label.Name = "Room_number_label";
            this.Room_number_label.Size = new System.Drawing.Size(89, 13);
            this.Room_number_label.TabIndex = 15;
            this.Room_number_label.Text = "Номер комнаты";
            // 
            // Room_number_textBox
            // 
            this.Room_number_textBox.Location = new System.Drawing.Point(102, 23);
            this.Room_number_textBox.Name = "Room_number_textBox";
            this.Room_number_textBox.Size = new System.Drawing.Size(62, 20);
            this.Room_number_textBox.TabIndex = 16;
            // 
            // Number_of_people_textBox
            // 
            this.Number_of_people_textBox.Location = new System.Drawing.Point(128, 53);
            this.Number_of_people_textBox.Name = "Number_of_people_textBox";
            this.Number_of_people_textBox.Size = new System.Drawing.Size(36, 20);
            this.Number_of_people_textBox.TabIndex = 18;
            // 
            // Number_of_people_label
            // 
            this.Number_of_people_label.AutoSize = true;
            this.Number_of_people_label.Location = new System.Drawing.Point(13, 53);
            this.Number_of_people_label.Name = "Number_of_people_label";
            this.Number_of_people_label.Size = new System.Drawing.Size(110, 13);
            this.Number_of_people_label.TabIndex = 17;
            this.Number_of_people_label.Text = "Количество человек";
            // 
            // Comfort_textBox
            // 
            this.Comfort_textBox.Location = new System.Drawing.Point(128, 83);
            this.Comfort_textBox.Name = "Comfort_textBox";
            this.Comfort_textBox.Size = new System.Drawing.Size(36, 20);
            this.Comfort_textBox.TabIndex = 20;
            // 
            // Comfort_label
            // 
            this.Comfort_label.AutoSize = true;
            this.Comfort_label.Location = new System.Drawing.Point(13, 83);
            this.Comfort_label.Name = "Comfort_label";
            this.Comfort_label.Size = new System.Drawing.Size(105, 13);
            this.Comfort_label.TabIndex = 19;
            this.Comfort_label.Text = "Уровень комфорта";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(102, 113);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(62, 20);
            this.Price_textBox.TabIndex = 22;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(13, 113);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(33, 13);
            this.Price_label.TabIndex = 21;
            this.Price_label.Text = "Цена";
            // 
            // Room_StatusID_textBox
            // 
            this.Room_StatusID_textBox.Location = new System.Drawing.Point(303, 53);
            this.Room_StatusID_textBox.Name = "Room_StatusID_textBox";
            this.Room_StatusID_textBox.Size = new System.Drawing.Size(62, 20);
            this.Room_StatusID_textBox.TabIndex = 26;
            // 
            // Room_StatusID_label
            // 
            this.Room_StatusID_label.AutoSize = true;
            this.Room_StatusID_label.Location = new System.Drawing.Point(213, 53);
            this.Room_StatusID_label.Name = "Room_StatusID_label";
            this.Room_StatusID_label.Size = new System.Drawing.Size(82, 13);
            this.Room_StatusID_label.TabIndex = 25;
            this.Room_StatusID_label.Text = "Room_StatusID";
            // 
            // Floor_textBox
            // 
            this.Floor_textBox.Location = new System.Drawing.Point(303, 23);
            this.Floor_textBox.Name = "Floor_textBox";
            this.Floor_textBox.Size = new System.Drawing.Size(62, 20);
            this.Floor_textBox.TabIndex = 24;
            // 
            // Floor_label
            // 
            this.Floor_label.AutoSize = true;
            this.Floor_label.Location = new System.Drawing.Point(213, 23);
            this.Floor_label.Name = "Floor_label";
            this.Floor_label.Size = new System.Drawing.Size(33, 13);
            this.Floor_label.TabIndex = 23;
            this.Floor_label.Text = "Этаж";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(303, 103);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(371, 82);
            this.Description_textBox.TabIndex = 28;
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(213, 103);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(57, 13);
            this.Description_label.TabIndex = 27;
            this.Description_label.Text = "Описание";
            // 
            // Old_room_number_textBox
            // 
            this.Old_room_number_textBox.Location = new System.Drawing.Point(596, 79);
            this.Old_room_number_textBox.Name = "Old_room_number_textBox";
            this.Old_room_number_textBox.Size = new System.Drawing.Size(78, 20);
            this.Old_room_number_textBox.TabIndex = 30;
            // 
            // Old_room_number_label
            // 
            this.Old_room_number_label.AutoSize = true;
            this.Old_room_number_label.Location = new System.Drawing.Point(403, 83);
            this.Old_room_number_label.Name = "Old_room_number_label";
            this.Old_room_number_label.Size = new System.Drawing.Size(187, 13);
            this.Old_room_number_label.TabIndex = 29;
            this.Old_room_number_label.Text = "Старый номер комнаты для Update";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomStatusIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.room_StatusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(697, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(165, 106);
            this.dataGridView1.TabIndex = 31;
            // 
            // roomStatusIDDataGridViewTextBoxColumn1
            // 
            this.roomStatusIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.roomStatusIDDataGridViewTextBoxColumn1.DataPropertyName = "Room_StatusID";
            this.roomStatusIDDataGridViewTextBoxColumn1.HeaderText = "Room_StatusID";
            this.roomStatusIDDataGridViewTextBoxColumn1.Name = "roomStatusIDDataGridViewTextBoxColumn1";
            this.roomStatusIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roomStatusIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomStatusIDDataGridViewTextBoxColumn1.Width = 5;
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
            // room_StatusBindingSource
            // 
            this.room_StatusBindingSource.DataMember = "Room_Status";
            this.room_StatusBindingSource.DataSource = this.hotelDataSet;
            // 
            // room_StatusTableAdapter
            // 
            this.room_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // Rooms_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Old_room_number_textBox);
            this.Controls.Add(this.Old_room_number_label);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Room_StatusID_textBox);
            this.Controls.Add(this.Room_StatusID_label);
            this.Controls.Add(this.Floor_textBox);
            this.Controls.Add(this.Floor_label);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Comfort_textBox);
            this.Controls.Add(this.Comfort_label);
            this.Controls.Add(this.Number_of_people_textBox);
            this.Controls.Add(this.Number_of_people_label);
            this.Controls.Add(this.Room_number_textBox);
            this.Controls.Add(this.Room_number_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Spec_serv_view);
            this.Controls.Add(this.Back_button);
            this.Name = "Rooms_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms_admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Special_services_admn_FormClosing);
            this.Load += new System.EventHandler(this.Rooms_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_StatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Spec_serv_view;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofpeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comfortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Room_number_label;
        private System.Windows.Forms.TextBox Room_number_textBox;
        private System.Windows.Forms.TextBox Number_of_people_textBox;
        private System.Windows.Forms.Label Number_of_people_label;
        private System.Windows.Forms.TextBox Comfort_textBox;
        private System.Windows.Forms.Label Comfort_label;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox Room_StatusID_textBox;
        private System.Windows.Forms.Label Room_StatusID_label;
        private System.Windows.Forms.TextBox Floor_textBox;
        private System.Windows.Forms.Label Floor_label;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Old_room_number_textBox;
        private System.Windows.Forms.Label Old_room_number_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource room_StatusBindingSource;
        private HotelDataSetTableAdapters.Room_StatusTableAdapter room_StatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}