namespace Hotel
{
    partial class Special_services
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
            this.Spec_serv_view = new System.Windows.Forms.DataGridView();
            this.servicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.servicesTableAdapter = new Hotel.HotelDataSetTableAdapters.ServicesTableAdapter();
            this.Back_button = new System.Windows.Forms.Button();
            this.Spec_service_chng_tbl_button = new System.Windows.Forms.Button();
            this.Gib_me_service = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Spec_serv_view
            // 
            this.Spec_serv_view.AllowUserToAddRows = false;
            this.Spec_serv_view.AllowUserToDeleteRows = false;
            this.Spec_serv_view.AutoGenerateColumns = false;
            this.Spec_serv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Spec_serv_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicenameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Spec_serv_view.DataSource = this.servicesBindingSource;
            this.Spec_serv_view.Location = new System.Drawing.Point(13, 13);
            this.Spec_serv_view.Name = "Spec_serv_view";
            this.Spec_serv_view.ReadOnly = true;
            this.Spec_serv_view.Size = new System.Drawing.Size(749, 135);
            this.Spec_serv_view.TabIndex = 0;
            // 
            // servicenameDataGridViewTextBoxColumn
            // 
            this.servicenameDataGridViewTextBoxColumn.DataPropertyName = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.HeaderText = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.Name = "servicenameDataGridViewTextBoxColumn";
            this.servicenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 500;
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
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(627, 163);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 2;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Spec_service_chng_tbl_button
            // 
            this.Spec_service_chng_tbl_button.Location = new System.Drawing.Point(174, 164);
            this.Spec_service_chng_tbl_button.Name = "Spec_service_chng_tbl_button";
            this.Spec_service_chng_tbl_button.Size = new System.Drawing.Size(422, 55);
            this.Spec_service_chng_tbl_button.TabIndex = 3;
            this.Spec_service_chng_tbl_button.Text = "Изменить таблицу";
            this.Spec_service_chng_tbl_button.UseVisualStyleBackColor = true;
            this.Spec_service_chng_tbl_button.Click += new System.EventHandler(this.Spec_service_chng_tbl_button_Click);
            // 
            // Gib_me_service
            // 
            this.Gib_me_service.Location = new System.Drawing.Point(13, 164);
            this.Gib_me_service.Name = "Gib_me_service";
            this.Gib_me_service.Size = new System.Drawing.Size(135, 55);
            this.Gib_me_service.TabIndex = 4;
            this.Gib_me_service.Text = "Заказать доп. услугу";
            this.Gib_me_service.UseVisualStyleBackColor = true;
            this.Gib_me_service.Click += new System.EventHandler(this.Gib_me_service_Click);
            // 
            // Special_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 231);
            this.Controls.Add(this.Gib_me_service);
            this.Controls.Add(this.Spec_service_chng_tbl_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Spec_serv_view);
            this.Name = "Special_services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Special_services";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Special_services_FormClosing);
            this.Load += new System.EventHandler(this.Special_services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Spec_serv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public string Perm;
        public string HashedPass;
        private System.Windows.Forms.DataGridView Spec_serv_view;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HotelDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Spec_service_chng_tbl_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Gib_me_service;
    }
}