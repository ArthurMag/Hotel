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
    public partial class Special_services_admn : Form
    {
        public Special_services_admn(string Pass)
        {
            InitializeComponent();
            this.Pass = Pass;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Special_services_admn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.hotelDataSet.Services);

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

        private void Special_services_admn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button/*Hotel.Special_services_admn*/)
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
                string query = "DECLARE @Service_Name as varchar(30) = '" + Service_name_textBox.Text.Trim() +
                    "' DECLARE @Price as varchar(30) = '" + Service_price_textBox.Text.Trim() +
                    "' DECLARE @Description as varchar(max) = '" + Service_description_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Insert_Service @Service_Name, @Price, @Description, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
                sqlc.Close();
            }
            catch(Exception MyMessage) 
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
                string query = "DECLARE @Old_Service_Name as varchar(30) = '" + Old_service_name_textBox.Text.Trim() +
                    "' DECLARE @Service_Name as varchar(30) = '" + Service_name_textBox.Text.Trim() +
                    "' DECLARE @Price as varchar(30) = '" + Service_price_textBox.Text.Trim() +
                    "' DECLARE @Description as varchar(max) = '" + Service_description_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Update_Service @Old_Service_Name, @Service_Name, @Price, @Description, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
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
                string query = "DECLARE @Service_Name as varchar(30) = '" + Service_name_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Delete_Service @Service_Name, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
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