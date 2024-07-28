using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Shedule_admin : Form
    {
        public Shedule_admin(string Pass)
        {
            InitializeComponent();
            this.Pass = Pass;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Shedule_admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.hotelDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Shedule". При необходимости она может быть перемещена или удалена.
            this.sheduleTableAdapter.Fill(this.hotelDataSet.Shedule);

        }

        private void sqlc_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            string MyMessage = (e.Message);
            MessageBox.Show(MyMessage.ToString());
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shedule_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                Owner.Show();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                //Pass = "0x53199297CB044FF2EBBC65213F16E297F265FD4D349B7140B247F0D7A0F03212"; //wrong for testing
                string query = "DECLARE @Date as varchar(30) = '" + Date_textBox.Text.Trim() +
                    "' DECLARE @Shift as varchar(30) = '" + Shift_textBox.Text.Trim() +
                    "' DECLARE @StaffID as varchar(max) = '" + StaffID_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Insert_Shedule @Date, @Shift, @StaffID, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.staffTableAdapter.Fill(this.hotelDataSet.Staff);
                this.sheduleTableAdapter.Fill(this.hotelDataSet.Shedule);
                sqlc.Close();
            }
            catch (Exception MyMessage)
            {
                MessageBox.Show(MyMessage.Message.ToString());
                sqlc.Close();
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                string query = "DECLARE @Date as varchar(30) = '" + Date_textBox.Text.Trim() +
                    "' DECLARE @Shift as varchar(30) = '" + Shift_textBox.Text.Trim() +
                    "' DECLARE @StaffID as varchar(max) = '" + StaffID_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' DECLARE @Old_Date as varchar(30) = '" + Old_Data_textBox.Text.Trim() +
                    "' DECLARE @Old_Shift as varchar(30) = '" + Old_Shift_textBox.Text.Trim() +
                    "' DECLARE @Old_StaffID as varchar(30) = '" + Old_StaffID_textBox.Text.Trim() +
                    "' EXEC Update_Shedule  @Date, @Shift, @StaffID, @SaltedPass, @Old_Date, @Old_Shift, @Old_StaffID";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.staffTableAdapter.Fill(this.hotelDataSet.Staff);
                this.sheduleTableAdapter.Fill(this.hotelDataSet.Shedule);
                sqlc.Close();
            }
            catch (Exception MyMessage)
            {
                MessageBox.Show(MyMessage.Message.ToString());
                sqlc.Close();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                string query = "DECLARE @Date as varchar(30) = '" + Date_textBox.Text.Trim() +
                    "' DECLARE @Shift as varchar(30) = '" + Shift_textBox.Text.Trim() +
                    "' DECLARE @StaffID as varchar(max) = '" + StaffID_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Delete_Shedule @Date, @Shift, @StaffID, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.staffTableAdapter.Fill(this.hotelDataSet.Staff);
                this.sheduleTableAdapter.Fill(this.hotelDataSet.Shedule);
                sqlc.Close();
            }
            catch (Exception MyMessage)
            {
                MessageBox.Show(MyMessage.Message.ToString());
                sqlc.Close();
            }
        }
    }
}
