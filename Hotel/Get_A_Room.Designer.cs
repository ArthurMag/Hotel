namespace Hotel
{
    partial class Get_A_Room
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
            this.FreeRoomsGrid = new System.Windows.Forms.DataGridView();
            this.Back_button = new System.Windows.Forms.Button();
            this.Notice_about_grid_label = new System.Windows.Forms.Label();
            this.Room_number_label = new System.Windows.Forms.Label();
            this.Room_number_textBox = new System.Windows.Forms.TextBox();
            this.Notice_label = new System.Windows.Forms.Label();
            this.Move_in_button = new System.Windows.Forms.Button();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofpeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comfortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.free_RoomsTableAdapter = new Hotel.HotelDataSetTableAdapters.Free_RoomsTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.FreeRoomsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.free_RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FreeRoomsGrid
            // 
            this.FreeRoomsGrid.AutoGenerateColumns = false;
            this.FreeRoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreeRoomsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expr1DataGridViewTextBoxColumn,
            this.roomnumberDataGridViewTextBoxColumn,
            this.numberofpeopleDataGridViewTextBoxColumn,
            this.comfortDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewTextBoxColumn});
            this.FreeRoomsGrid.DataSource = this.free_RoomsBindingSource;
            this.FreeRoomsGrid.GridColor = System.Drawing.SystemColors.Window;
            this.FreeRoomsGrid.Location = new System.Drawing.Point(9, 129);
            this.FreeRoomsGrid.Name = "FreeRoomsGrid";
            this.FreeRoomsGrid.Size = new System.Drawing.Size(654, 204);
            this.FreeRoomsGrid.TabIndex = 0;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(669, 277);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Notice_about_grid_label
            // 
            this.Notice_about_grid_label.AutoSize = true;
            this.Notice_about_grid_label.Location = new System.Drawing.Point(6, 113);
            this.Notice_about_grid_label.Name = "Notice_about_grid_label";
            this.Notice_about_grid_label.Size = new System.Drawing.Size(316, 13);
            this.Notice_about_grid_label.TabIndex = 5;
            this.Notice_about_grid_label.Text = "Внизу показаны все свободные комнаты на данный момент";
            // 
            // Room_number_label
            // 
            this.Room_number_label.AutoSize = true;
            this.Room_number_label.Location = new System.Drawing.Point(12, 70);
            this.Room_number_label.Name = "Room_number_label";
            this.Room_number_label.Size = new System.Drawing.Size(89, 13);
            this.Room_number_label.TabIndex = 6;
            this.Room_number_label.Text = "Номер комнаты";
            // 
            // Room_number_textBox
            // 
            this.Room_number_textBox.Location = new System.Drawing.Point(107, 67);
            this.Room_number_textBox.Name = "Room_number_textBox";
            this.Room_number_textBox.Size = new System.Drawing.Size(100, 20);
            this.Room_number_textBox.TabIndex = 7;
            // 
            // Notice_label
            // 
            this.Notice_label.AutoSize = true;
            this.Notice_label.Location = new System.Drawing.Point(6, 13);
            this.Notice_label.Name = "Notice_label";
            this.Notice_label.Size = new System.Drawing.Size(521, 13);
            this.Notice_label.TabIndex = 8;
            this.Notice_label.Text = "Чтобы заселиться в комнату или забронировать ее , у вас должны быть заполнены лич" +
    "ные данные!";
            // 
            // Move_in_button
            // 
            this.Move_in_button.Location = new System.Drawing.Point(247, 65);
            this.Move_in_button.Name = "Move_in_button";
            this.Move_in_button.Size = new System.Drawing.Size(75, 23);
            this.Move_in_button.TabIndex = 9;
            this.Move_in_button.Text = "Заселиться";
            this.Move_in_button.UseVisualStyleBackColor = true;
            this.Move_in_button.Click += new System.EventHandler(this.Move_in_button_Click);
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.expr1DataGridViewTextBoxColumn.Width = 59;
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
            // roomStatusDataGridViewTextBoxColumn
            // 
            this.roomStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomStatusDataGridViewTextBoxColumn.DataPropertyName = "Room_Status";
            this.roomStatusDataGridViewTextBoxColumn.HeaderText = "Room_Status";
            this.roomStatusDataGridViewTextBoxColumn.Name = "roomStatusDataGridViewTextBoxColumn";
            this.roomStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomStatusDataGridViewTextBoxColumn.Width = 96;
            // 
            // free_RoomsBindingSource
            // 
            this.free_RoomsBindingSource.DataMember = "Free_Rooms";
            this.free_RoomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // free_RoomsTableAdapter
            // 
            this.free_RoomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // Get_A_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 337);
            this.Controls.Add(this.Move_in_button);
            this.Controls.Add(this.Notice_label);
            this.Controls.Add(this.Room_number_textBox);
            this.Controls.Add(this.Room_number_label);
            this.Controls.Add(this.Notice_about_grid_label);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.FreeRoomsGrid);
            this.Name = "Get_A_Room";
            this.Text = "Get_A_Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Get_A_Room_FormClosing);
            this.Load += new System.EventHandler(this.Get_A_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreeRoomsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.free_RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.DataGridView FreeRoomsGrid;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label Notice_about_grid_label;
        private System.Windows.Forms.Label Room_number_label;
        private System.Windows.Forms.TextBox Room_number_textBox;
        private System.Windows.Forms.Label Notice_label;
        private System.Windows.Forms.Button Move_in_button;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource free_RoomsBindingSource;
        private HotelDataSetTableAdapters.Free_RoomsTableAdapter free_RoomsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofpeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comfortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
    }
}