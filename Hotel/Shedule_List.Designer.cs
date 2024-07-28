namespace Hotel
{
    partial class Shedule_list
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
            this.Shedule_List_View = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleWithNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.shedule_With_NamesTableAdapter = new Hotel.HotelDataSetTableAdapters.Shedule_With_NamesTableAdapter();
            this.sheduleWithNamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Shedule_List_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleWithNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleWithNamesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(548, 366);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 56);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Shedule_List_View
            // 
            this.Shedule_List_View.AllowUserToAddRows = false;
            this.Shedule_List_View.AllowUserToDeleteRows = false;
            this.Shedule_List_View.AutoGenerateColumns = false;
            this.Shedule_List_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shedule_List_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.patronymDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn});
            this.Shedule_List_View.DataSource = this.sheduleWithNamesBindingSource1;
            this.Shedule_List_View.Location = new System.Drawing.Point(13, 13);
            this.Shedule_List_View.Name = "Shedule_List_View";
            this.Shedule_List_View.ReadOnly = true;
            this.Shedule_List_View.Size = new System.Drawing.Size(670, 332);
            this.Shedule_List_View.TabIndex = 2;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymDataGridViewTextBoxColumn
            // 
            this.patronymDataGridViewTextBoxColumn.DataPropertyName = "Patronym";
            this.patronymDataGridViewTextBoxColumn.HeaderText = "Patronym";
            this.patronymDataGridViewTextBoxColumn.Name = "patronymDataGridViewTextBoxColumn";
            this.patronymDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sheduleWithNamesBindingSource
            // 
            this.sheduleWithNamesBindingSource.DataMember = "Shedule_With_Names";
            this.sheduleWithNamesBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shedule_With_NamesTableAdapter
            // 
            this.shedule_With_NamesTableAdapter.ClearBeforeFill = true;
            // 
            // sheduleWithNamesBindingSource1
            // 
            this.sheduleWithNamesBindingSource1.DataMember = "Shedule_With_Names";
            this.sheduleWithNamesBindingSource1.DataSource = this.hotelDataSet;
            // 
            // Shedule_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 436);
            this.Controls.Add(this.Shedule_List_View);
            this.Controls.Add(this.Back_button);
            this.Name = "Shedule_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shedule_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shedule_List_FormClosing);
            this.Load += new System.EventHandler(this.Shedule_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shedule_List_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleWithNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleWithNamesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView Shedule_List_View;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource sheduleWithNamesBindingSource;
        private HotelDataSetTableAdapters.Shedule_With_NamesTableAdapter shedule_With_NamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sheduleWithNamesBindingSource1;
    }
}