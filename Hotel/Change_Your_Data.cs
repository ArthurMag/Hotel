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
    public partial class Change_Your_Data : Form
    {
        public Change_Your_Data(string hashedpass, string perm)
        {
            InitializeComponent();
            this.Perm = perm;
            this.HashedPass = hashedpass;
            this.Connection = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Connection);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Change_Your_Data_Load(object sender, EventArgs e)
        {
            if ((Perm != "1") && (Perm != "2") && (Perm != "4"))
            {
                Confirm_as_staff_label.Hide();
                Confirm_as_staff_button.Hide();
            }
            
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Your_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void sqlc_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            string MyMessage = (e.Message);
            MessageBox.Show(MyMessage.ToString()); 
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (sqlc.State != System.Data.ConnectionState.Open)
            {
                sqlc.Open();
            }
            string temp_query = "SELECT * FROM Clients " + 
                "INNER JOIN Autentification ON Autentification.UserID = Clients.UserID " + 
                "WHERE Autentification.Password = CONVERT(varbinary(max), '" + HashedPass + "' , 1)";
            SqlCommand cmd = new SqlCommand(temp_query, sqlc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                //HashedPass = "0x224AD4DFF88A60DC83399DE6FC2931853E5A38CD5F4B90DD0B65F1D46F40C68D"; // не правильный, для проверки
                string query = "DECLARE @Last_Name as varchar(30) = '" + Last_Name_textBox.Text.Trim() + 
                    "'; DECLARE @Name as varchar(30) = '" + First_Name_textBox.Text.Trim() + 
                    "'; DECLARE @Patronym as varchar(30) = '" + Patronym_textBox.Text.Trim() + 
                    "'; DECLARE @Passport_number as varchar(10) = '" + Passport_textBox.Text.Trim() + 
                    "'; DECLARE @Permanent_living_location as varchar(MAX) = '" + Permanent_living_location_textBox.Text.Trim() + 
                    "'; DECLARE @Phone_number as varchar(30) = '" + Phone_number_textBox.Text.Trim() + 
                    "'; DECLARE @Birthdate as date = '" + Birthday_textBox.Text.Trim() + 
                    "'; DECLARE @HashedPass as varchar(max) = '" + HashedPass + 
                    "'; EXEC Change_Clients_Data @Last_Name, @Name, @Patronym, @Passport_number, @Permanent_living_location, @Phone_number, @Birthdate, @HashedPass";
                SqlCommand cmdT = new SqlCommand(query, sqlc);
                if (cmdT.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success!");
                    cmd.Dispose();
                    cmdT.Dispose();
                    this.Close();
                }
                else
                {
                    cmd.Dispose();
                    cmdT.Dispose();
                }
            }
            else
            {
                dr.Close();
                //HashedPass = "0x224AD4DFF88A60DC83399DE6FC2931853E5A38CD5F4B90DD0B65F1D46F40C68D"; // не правильный, для проверки
                string query = "DECLARE @Last_Name as varchar(30) = '" + Last_Name_textBox.Text.Trim() + 
                    "'; DECLARE @Name as varchar(30) = '" + First_Name_textBox.Text.Trim() + 
                    "'; DECLARE @Patronym as varchar(30) = '" + Patronym_textBox.Text.Trim() + 
                    "'; DECLARE @Passport_number as varchar(10) = '" + Passport_textBox.Text.Trim() + 
                    "'; DECLARE @Permanent_living_location as varchar(MAX) = '" + Permanent_living_location_textBox.Text.Trim() + 
                    "'; DECLARE @Phone_number as varchar(30) = '" + Phone_number_textBox.Text.Trim() + 
                    "'; DECLARE @Birthdate as date = '" + Birthday_textBox.Text.Trim() + 
                    "'; DECLARE @HashedPass as varchar(max) = '" + HashedPass + 
                    "'; EXEC Add_Client @Last_Name, @Name, @Patronym, @Passport_number, @Permanent_living_location, @Phone_number, @Birthdate, @HashedPass";
                SqlCommand cmdF = new SqlCommand(query, sqlc);
                if (cmdF.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success!");
                    cmd.Dispose();
                    cmdF.Dispose();
                    this.Close();
                }
                else
                {
                    cmd.Dispose();
                    cmdF.Dispose();
                }
            }
            sqlc.Close();
        }

        private void Confirm_as_staff_button_Click(object sender, EventArgs e)
        {
            if (sqlc.State != System.Data.ConnectionState.Open)
            {
                sqlc.Open();
            }
            string temp_query = "SELECT * FROM Staff " +
                "INNER JOIN Autentification ON Autentification.UserID = Staff.UserID " +
                "WHERE Autentification.Password = CONVERT(varbinary(max), '" + HashedPass + "' , 1)";
            SqlCommand cmd = new SqlCommand(temp_query, sqlc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                //HashedPass = "0x224AD4DFF88A60DC83399DE6FC2931853E5A38CD5F4B90DD0B65F1D46F40C68D"; // не правильный, для проверки
                string query = "DECLARE @Last_Name as varchar(30) = '" + Last_Name_textBox.Text.Trim() +
                        "'; DECLARE @Name as varchar(30) = '" + First_Name_textBox.Text.Trim() +
                        "'; DECLARE @Patronym as varchar(30) = '" + Patronym_textBox.Text.Trim() +
                        "'; DECLARE @Permanent_living_location as varchar(MAX) = '" + Permanent_living_location_textBox.Text.Trim() +
                        "'; DECLARE @Phone_number as varchar(30) = '" + Phone_number_textBox.Text.Trim() +
                        "'; DECLARE @Birthdate as date = '" + Birthday_textBox.Text.Trim() +
                        "'; DECLARE @HashedPass as varchar(max) = '" + HashedPass +
                        "'; EXEC Change_Staff_Data @Last_Name, @Name, @Patronym, @Permanent_living_location, @Phone_number, @Birthdate, @HashedPass";
                SqlCommand cmdT = new SqlCommand(query, sqlc);
                if (cmdT.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success!");
                    cmd.Dispose();
                    cmdT.Dispose();
                    this.Close();
                }
                else
                {
                    cmd.Dispose();
                    cmdT.Dispose();
                }
            }
            else
            {
                dr.Close();
                //HashedPass = "0x224AD4DFF88A60DC83399DE6FC2931853E5A38CD5F4B90DD0B65F1D46F40C68D"; // не правильный, для проверки
                string query = "DECLARE @Last_Name as varchar(30) = '" + Last_Name_textBox.Text.Trim() +
                "'; DECLARE @Name as varchar(30) = '" + First_Name_textBox.Text.Trim() +
                "'; DECLARE @Patronym as varchar(30) = '" + Patronym_textBox.Text.Trim() +
                "'; DECLARE @Permanent_living_location as varchar(MAX) = '" + Permanent_living_location_textBox.Text.Trim() +
                "'; DECLARE @Phone_number as varchar(30) = '" + Phone_number_textBox.Text.Trim() +
                "'; DECLARE @Birthdate as date = '" + Birthday_textBox.Text.Trim() +
                "'; DECLARE @HashedPass as varchar(max) = '" + HashedPass +
                "'; EXEC Add_Staff @Last_Name, @Name, @Patronym, @Permanent_living_location, @Phone_number, @Birthdate, @HashedPass";
                SqlCommand cmdF = new SqlCommand(query, sqlc);
                if (cmdF.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success!");
                    cmd.Dispose();
                    cmdF.Dispose();
                    this.Close();
                }
                else
                {
                    cmd.Dispose();
                    cmdF.Dispose();
                }
            }
            sqlc.Close();
        }
    }
}
