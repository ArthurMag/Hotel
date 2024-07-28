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
    public partial class Secret_And_Cool_Admin : Form
    {
        public Secret_And_Cool_Admin(string Pass, string Perm)
        {
            InitializeComponent();

            this.Pass = Pass;
            this.Perm = Perm;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlc_InfoMessage);
            sqlc.Close();

        }

        private void SACA_Load(object sender, EventArgs e)
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

        private void SACA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                Owner.Show();
        }

        private void GoTo_Autentification_button_Click(object sender, EventArgs e)
        {
            Admins_Autentification AA = new Admins_Autentification(this.Pass, this.Perm);
            this.Hide();
            AA.Owner = this;
            AA.ShowDialog();
        }

        private void GoTo_Clients_button_Click(object sender, EventArgs e)
        {
            Admins_Clients AC = new Admins_Clients(this.Pass, this.Perm);
            this.Hide();
            AC.Owner = this;
            AC.ShowDialog();
        }

        private void GoTo_Staff_button_Click(object sender, EventArgs e)
        {
            Admins_Staff AS = new Admins_Staff(this.Pass, this.Perm);
            this.Hide();
            AS.Owner = this;
            AS.ShowDialog();
        }

        private void GoTo_Orders_button_Click(object sender, EventArgs e)
        {
            Admins_Orders AO = new Admins_Orders();
            this.Hide();
            AO.Owner = this;
            AO.ShowDialog();
        }

        private void GoTo_Settlement_button_Click(object sender, EventArgs e)
        {
            Admins_Settlement AST = new Admins_Settlement(this.Pass, this.Perm);
            this.Hide();
            AST.Owner = this;
            AST.ShowDialog();
        }
    }
}
