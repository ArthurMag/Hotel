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
    public partial class Registration_form : Form
    {
        public Autentification_form Back_to_aut { get; set; }

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

        public Registration_form()
        {
            InitializeComponent();

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void sqlc_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            string MyMessage = (e.Message);
            MessageBox.Show(MyMessage.ToString());
        }
        
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Back_to_aut != null)
                Back_to_aut.Show();
        }

        private void Registration_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Back_to_aut != null)
                Back_to_aut.Show();
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                string query = "SELECT CAST((Ident_Current('Autentification') + 1) AS varchar(10))";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                string salt;
                salt = dtbl.Rows[0][0].ToString();
                string value = Password_textBox.Text.Trim() + salt; 
                value = sha256_hash(value);
                value = "0x" + value;
                string query2 = "EXEC Add_User '" + Login_textBox.Text.Trim() + "', '" + value + "'";
                SqlCommand cmd = new SqlCommand(query2, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                sqlc.Close();
                this.Close();
            }
            catch (Exception MyMessage)
            {
                MessageBox.Show(MyMessage.Message.ToString());
                sqlc.Close();
            }
        }
    }

}
