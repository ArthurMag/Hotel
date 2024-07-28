namespace Hotel
{
    partial class Special_services_admn
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
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.servicesTableAdapter = new Hotel.HotelDataSetTableAdapters.ServicesTableAdapter();
            this.Service_name_textBox = new System.Windows.Forms.TextBox();
            this.Service_name_label = new System.Windows.Forms.Label();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Service_price_label = new System.Windows.Forms.Label();
            this.Service_price_textBox = new System.Windows.Forms.TextBox();
            this.Service_description_label = new System.Windows.Forms.Label();
            this.Service_description_textBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Old_service_name_label = new System.Windows.Forms.Label();
            this.Old_service_name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(727, 334);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 3;
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
            this.serviceIDDataGridViewTextBoxColumn,
            this.servicenameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Spec_serv_view.DataSource = this.servicesBindingSource;
            this.Spec_serv_view.Location = new System.Drawing.Point(1, 193);
            this.Spec_serv_view.Name = "Spec_serv_view";
            this.Spec_serv_view.ReadOnly = true;
            this.Spec_serv_view.Size = new System.Drawing.Size(861, 135);
            this.Spec_serv_view.TabIndex = 4;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceIDDataGridViewTextBoxColumn.Width = 79;
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
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // Service_name_textBox
            // 
            this.Service_name_textBox.Location = new System.Drawing.Point(115, 26);
            this.Service_name_textBox.Name = "Service_name_textBox";
            this.Service_name_textBox.Size = new System.Drawing.Size(266, 20);
            this.Service_name_textBox.TabIndex = 5;
            // 
            // Service_name_label
            // 
            this.Service_name_label.AutoSize = true;
            this.Service_name_label.Location = new System.Drawing.Point(16, 26);
            this.Service_name_label.Name = "Service_name_label";
            this.Service_name_label.Size = new System.Drawing.Size(93, 13);
            this.Service_name_label.TabIndex = 6;
            this.Service_name_label.Text = "Название услуги";
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(437, 23);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(107, 50);
            this.Insert_button.TabIndex = 7;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Service_price_label
            // 
            this.Service_price_label.AutoSize = true;
            this.Service_price_label.Location = new System.Drawing.Point(16, 65);
            this.Service_price_label.Name = "Service_price_label";
            this.Service_price_label.Size = new System.Drawing.Size(69, 13);
            this.Service_price_label.TabIndex = 9;
            this.Service_price_label.Text = "Цена услуги";
            // 
            // Service_price_textBox
            // 
            this.Service_price_textBox.Location = new System.Drawing.Point(115, 65);
            this.Service_price_textBox.Name = "Service_price_textBox";
            this.Service_price_textBox.Size = new System.Drawing.Size(266, 20);
            this.Service_price_textBox.TabIndex = 8;
            // 
            // Service_description_label
            // 
            this.Service_description_label.AutoSize = true;
            this.Service_description_label.Location = new System.Drawing.Point(16, 104);
            this.Service_description_label.Name = "Service_description_label";
            this.Service_description_label.Size = new System.Drawing.Size(93, 13);
            this.Service_description_label.TabIndex = 11;
            this.Service_description_label.Text = "Описание услуги";
            // 
            // Service_description_textBox
            // 
            this.Service_description_textBox.Location = new System.Drawing.Point(115, 104);
            this.Service_description_textBox.Multiline = true;
            this.Service_description_textBox.Name = "Service_description_textBox";
            this.Service_description_textBox.Size = new System.Drawing.Size(689, 86);
            this.Service_description_textBox.TabIndex = 10;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(567, 23);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(107, 50);
            this.Update_button.TabIndex = 12;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(697, 23);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(107, 50);
            this.Delete_button.TabIndex = 13;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Old_service_name_label
            // 
            this.Old_service_name_label.AutoSize = true;
            this.Old_service_name_label.Location = new System.Drawing.Point(434, 81);
            this.Old_service_name_label.Name = "Old_service_name_label";
            this.Old_service_name_label.Size = new System.Drawing.Size(190, 13);
            this.Old_service_name_label.TabIndex = 15;
            this.Old_service_name_label.Text = "Название старой услуги при Update";
            // 
            // Old_service_name_textBox
            // 
            this.Old_service_name_textBox.Location = new System.Drawing.Point(630, 78);
            this.Old_service_name_textBox.Name = "Old_service_name_textBox";
            this.Old_service_name_textBox.Size = new System.Drawing.Size(174, 20);
            this.Old_service_name_textBox.TabIndex = 14;
            // 
            // Special_services_admn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 393);
            this.Controls.Add(this.Old_service_name_label);
            this.Controls.Add(this.Old_service_name_textBox);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Service_description_label);
            this.Controls.Add(this.Service_description_textBox);
            this.Controls.Add(this.Service_price_label);
            this.Controls.Add(this.Service_price_textBox);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Service_name_label);
            this.Controls.Add(this.Service_name_textBox);
            this.Controls.Add(this.Spec_serv_view);
            this.Controls.Add(this.Back_button);
            this.Name = "Special_services_admn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Special_services_admn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Special_services_admn_FormClosing);
            this.Load += new System.EventHandler(this.Special_services_admn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private string Pass;
        private string Conn;
        System.Data.SqlClient.SqlConnection sqlc;

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Spec_serv_view;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HotelDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Service_name_textBox;
        private System.Windows.Forms.Label Service_name_label;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Label Service_price_label;
        private System.Windows.Forms.TextBox Service_price_textBox;
        private System.Windows.Forms.Label Service_description_label;
        private System.Windows.Forms.TextBox Service_description_textBox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label Old_service_name_label;
        private System.Windows.Forms.TextBox Old_service_name_textBox;
    }
}