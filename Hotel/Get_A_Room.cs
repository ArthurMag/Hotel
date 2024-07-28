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
    public partial class Get_A_Room : Form
    {
        public Get_A_Room(string Pass)
        {
            InitializeComponent();

            this.Pass = Pass;
            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();
        }

        private void Get_A_Room_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Free_Rooms". При необходимости она может быть перемещена или удалена.
            this.free_RoomsTableAdapter.Fill(this.hotelDataSet.Free_Rooms);

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
        private void Get_A_Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                Owner.Show();
        }


        private void Move_in_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlc.State != System.Data.ConnectionState.Open)
                {
                    sqlc.Open();
                }
                string query = "EXEC Move_In_A_Room '" + Room_number_textBox.Text.Trim() + "', '" + Pass + "'";
                SqlCommand cmd = new SqlCommand(query, sqlc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
                cmd.Dispose();
                this.free_RoomsTableAdapter.Fill(this.hotelDataSet.Free_Rooms);
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
