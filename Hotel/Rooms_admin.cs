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
    public partial class Rooms_admin : Form
    {
        public Rooms_admin(string HashedPass)
        {
            InitializeComponent();
            this.Pass = HashedPass;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Rooms_admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Room_Status". При необходимости она может быть перемещена или удалена.
            this.room_StatusTableAdapter.Fill(this.hotelDataSet.Room_Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);

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
                string query = "DECLARE @Room_number as varchar(30) = '" + Room_number_textBox.Text.Trim() +
                    "' DECLARE @Number_of_people as varchar(30) = '" + Number_of_people_textBox.Text.Trim() +
                    "' DECLARE @Comfort as varchar(30) = '" + Comfort_textBox.Text.Trim() +
                    "' DECLARE @Price as varchar(30) = '" + Price_textBox.Text.Trim() +
                    "' DECLARE @Floor as varchar(30) = '" + Floor_textBox.Text.Trim() +
                    "' DECLARE @Room_statusID as varchar(30) = '" + Room_StatusID_textBox.Text.Trim() +
                    "' DECLARE @Description as varchar(max) = '" + Description_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Insert_Room @Room_number, @Number_of_people, @Comfort, @Price, @Floor, @Room_statusID, @Description, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);
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
                string query = "DECLARE @Old_Room_number as varchar(30) = '" + Old_room_number_textBox.Text.Trim() +
                    "' DECLARE @Room_number as varchar(30) = '" + Room_number_textBox.Text.Trim() +
                    "' DECLARE @Number_of_people as varchar(30) = '" + Number_of_people_textBox.Text.Trim() +
                    "' DECLARE @Comfort as varchar(30) = '" + Comfort_textBox.Text.Trim() +
                    "' DECLARE @Price as varchar(30) = '" + Price_textBox.Text.Trim() +
                    "' DECLARE @Floor as varchar(30) = '" + Floor_textBox.Text.Trim() +
                    "' DECLARE @Room_statusID as varchar(30) = '" + Room_StatusID_textBox.Text.Trim() +
                    "' DECLARE @Description as varchar(max) = '" + Description_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Update_Room @Room_number, @Number_of_people, @Comfort, @Price, @Floor, @Room_statusID, @Description, @SaltedPass, @Old_Room_number";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);
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
                string query = "DECLARE @Room_number as varchar(30) = '" + Room_number_textBox.Text.Trim() +
                    "' DECLARE @SaltedPass as varchar(max) = '" + Pass +
                    "' EXEC Delete_Room @Room_number, @SaltedPass";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.roomsTableAdapter.Fill(this.hotelDataSet.Rooms);
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
