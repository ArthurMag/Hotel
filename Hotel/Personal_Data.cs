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
    public partial class Personal_Data : Form
    {
        public Personal_Data(string HashedPass)
        {
            InitializeComponent();
            this.HashedPass = HashedPass;
        }

        private void Personal_Data_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True");
            string query = "DECLARE @STRING_VARB AS VARCHAR(max) = '" + HashedPass + "' ;SELECT Clients.Last_name, Clients.Name AS First_Name, Clients.Patronym, Clients.Phone_number, Clients.Birthdate, Clients.Passport_number, Clients.Permanent_living_location FROM Clients INNER JOIN Autentification ON Autentification.UserID = Clients.UserID WHERE Autentification.Password = CONVERT(varbinary(max), @STRING_VARB, 1) ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Last_Name_textBox.Text = dtbl.Rows[0][0].ToString();
                First_Name_textBox.Text = dtbl.Rows[0][1].ToString();
                Patronym_textBox.Text = dtbl.Rows[0][2].ToString();
            }
            else
            {
                
            }
        }
        
        private void Change_Your_Data_Button_Click(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personal_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                Owner.Show();
        }
    }
}
