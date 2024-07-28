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
using System.Security.Cryptography;

namespace Hotel
{

    public partial class Entrance_form : Form
    {

        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public Autentification_form Back_to_aut { get; set; }

        public Entrance_form()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Back_to_aut != null)
                Back_to_aut.Show();
        }

        private void Entrance_form_Load(object sender, EventArgs e)
        { }

        private void Entrance_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True");
            string query = "SELECT Autentification.UserID FROM Autentification WHERE Autentification.Login = '" + Username_textBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string salt;
            if (dtbl.Rows.Count == 1)
            { salt = dtbl.Rows[0][0].ToString(); }
            else
            { salt = "-1"; }
            string value = Password_textBox.Text.Trim() + salt;
            value = sha256_hash(value);
            value = "0x" + value;
            string query2 = "SELECT* FROM Autentification WHERE Autentification.Login = '" + Username_textBox.Text.Trim() + "' AND Autentification.Password = CONVERT(varbinary(max), '" + value + "', 1);";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlc);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);
            if (dtbl2.Rows.Count == 1)
            {
                string permission = dtbl2.Rows[0][3].ToString();
                    string hashedpass = value;
                    string login = Username_textBox.Text.Trim();
                    Your_Personal_Space YRI = new Your_Personal_Space(login, hashedpass, permission);
                    this.Username_textBox.Clear();
                    this.Password_textBox.Clear();
                    YRI.Owner = this;
                    this.Hide();
                    YRI.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
        }

        private void Entrance_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Back_to_aut != null)
                    Back_to_aut.Show();
        }

    }
}
