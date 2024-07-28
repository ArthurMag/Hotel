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
    public partial class Make_A_Request : Form
    {
        public Make_A_Request(string Pass)
        {
            InitializeComponent();

            this.Pass = Pass;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Make_A_Request_Load(object sender, EventArgs e)
        {

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

        private void Make_A_Request_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.hotelDataSet.Services);

        }

        private void Make_a_request_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                string query = "EXEC Make_A_Request '" + Your_room_number_textBox.Text.Trim() + "', '"
                    + Service_name_textBox.Text.Trim() + "', '" + Amount_textBox.Text.Trim() + "', '" + Pass + "' ";
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
