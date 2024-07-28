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
    public partial class Your_Personal_Space : Form
    {
        //public Entrance_form Back_to_login { get; set; }
        public Your_Personal_Space(string login, string hashedpass, string perm)
        {

            InitializeComponent();
            this.Login = login;
            this.HashedPass = hashedpass;
            this.Perm = perm;

            this.Conn = "Data Source=LAPTOP-8KBND5PL; AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\Hotel.mdf; Initial Catalog=Hotel; Integrated Security=True";
            sqlc = new SqlConnection(Conn);
            sqlc.Close();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void Your_Personal_Space_Load(object sender, EventArgs e)
        {
            if ((this.Perm != "1") && (this.Perm != "2") && (this.Perm != "4"))
            {
                tabControl1.TabPages.Remove(Shedule_for_staff_tab);
                this.Staff_Data_Show_button.Hide();
                this.Client_Data_Show_button.Hide();
            }
            
            this.tabControl1.SelectedTab = Private_data_tab;
            if (sqlc.State != System.Data.ConnectionState.Open)
            {
                sqlc.Open();
            }
            //HashedPass = "0x53199297cb044ff2ebbc65213f16e297f265fd4d349b7140b247f0d7a0f03213"; // wrong for testing
            string query = "DECLARE @STRING_VARB AS VARCHAR(max) = '" + HashedPass + 
                "' ;SELECT Clients.Last_name, Clients.Name AS First_Name, Clients.Patronym, Clients.Phone_number, Clients.Birthdate, Clients.Passport_number, Clients.Permanent_living_location FROM Clients "+
                " INNER JOIN Autentification ON Autentification.UserID = Clients.UserID" +
                " WHERE Autentification.Password = CONVERT(varbinary(max), @STRING_VARB, 1) ";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Last_Name_textBox.Text = dr["Last_Name"].ToString();
                First_Name_textBox.Text = dr["First_Name"].ToString();
                Patronym_textBox.Text = dr["Patronym"].ToString();
                Phone_number_textBox.Text = dr["Phone_number"].ToString();
                string temp = dr["Birthdate"].ToString();
                Birthday_textBox.Text = temp.Remove(10, 8);
                Passport_textBox.Text = dr["Passport_number"].ToString();
                Permanent_living_location_textBox.Text = dr["Permanent_living_location"].ToString();
            }
            else
            {
                Last_Name_textBox.Text = "";
                First_Name_textBox.Text = "";
                Patronym_textBox.Text = "";
                Phone_number_textBox.Text = "";
                Birthday_textBox.Text = "";
                Passport_textBox.Text = "";
                Permanent_living_location_textBox.Text = "";
            }
            sqlc.Close();
        }

        // Личная инфа
        private void Staff_Data_Show_button_Click(object sender, EventArgs e)
        {
            if (sqlc.State != System.Data.ConnectionState.Open)
            {
                sqlc.Open();
            }
            //HashedPass = "0x53199297cb044ff2ebbc65213f16e297f265fd4d349b7140b247f0d7a0f03213"; // wrong for testing
            string query = "DECLARE @STRING_VARB AS VARCHAR(max) = '" + HashedPass + 
                "' ;SELECT Staff.Last_name, Staff.Name AS First_Name, Staff.Patronym, Staff.Phone_number, Staff.Birthdate, Staff.Permanent_living_location FROM Staff " +
                "INNER JOIN Autentification ON Autentification.UserID = Staff.UserID " +
                "WHERE Autentification.Password = CONVERT(varbinary(max), @STRING_VARB, 1) ";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Last_Name_textBox.Text = dr["Last_Name"].ToString();
                First_Name_textBox.Text = dr["First_Name"].ToString();
                Patronym_textBox.Text = dr["Patronym"].ToString();
                Phone_number_textBox.Text = dr["Phone_number"].ToString();
                string temp = dr["Birthdate"].ToString();
                Birthday_textBox.Text = temp.Remove(10, 8);
                Passport_textBox.Text = "-";
                Permanent_living_location_textBox.Text = dr["Permanent_living_location"].ToString();
            }
            else
            {
            Last_Name_textBox.Text = "";
            First_Name_textBox.Text = "";
            Patronym_textBox.Text = "";
            Phone_number_textBox.Text = "";
            Birthday_textBox.Text = "";
            Passport_textBox.Text = "";
            Permanent_living_location_textBox.Text = "";
            }
            sqlc.Close();
        }

        private void Client_Data_Show_button_Click(object sender, EventArgs e)
        {
            if (sqlc.State != System.Data.ConnectionState.Open)
            {
                sqlc.Open();
            }
            //HashedPass = "0x53199297cb044ff2ebbc65213f16e297f265fd4d349b7140b247f0d7a0f03213"; // wrong for testing
            string query = "DECLARE @STRING_VARB AS VARCHAR(max) = '" + HashedPass +
    "' ;SELECT Clients.Last_name, Clients.Name AS First_Name, Clients.Patronym, Clients.Phone_number, Clients.Birthdate, Clients.Passport_number, Clients.Permanent_living_location FROM Clients " +
    " INNER JOIN Autentification ON Autentification.UserID = Clients.UserID" +
    " WHERE Autentification.Password = CONVERT(varbinary(max), @STRING_VARB, 1) ";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Last_Name_textBox.Text = dr["Last_Name"].ToString();
                First_Name_textBox.Text = dr["First_Name"].ToString();
                Patronym_textBox.Text = dr["Patronym"].ToString();
                Phone_number_textBox.Text = dr["Phone_number"].ToString();
                string temp = dr["Birthdate"].ToString();
                Birthday_textBox.Text = temp.Remove(10, 8);
                Passport_textBox.Text = dr["Passport_number"].ToString();
                Permanent_living_location_textBox.Text = dr["Permanent_living_location"].ToString();
            }
            else
            {
                Last_Name_textBox.Text = "";
                First_Name_textBox.Text = "";
                Patronym_textBox.Text = "";
                Phone_number_textBox.Text = "";
                Birthday_textBox.Text = "";
                Passport_textBox.Text = "";
                Permanent_living_location_textBox.Text = "";
            }
            sqlc.Close();
        }

        // смена вкладок
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Private_data_tab)
            {
                try
                {
                    if (sqlc.State != System.Data.ConnectionState.Open)
                    {
                        sqlc.Open();
                    }
                    //HashedPass = "0x53199297cb044ff2ebbc65213f16e297f265fd4d349b7140b247f0d7a0f03213"; // wrong for testing
                    string query = "DECLARE @STRING_VARB AS VARCHAR(max) = '" + HashedPass +
            "' ;SELECT Clients.Last_name, Clients.Name AS First_Name, Clients.Patronym, Clients.Phone_number, Clients.Birthdate, Clients.Passport_number, Clients.Permanent_living_location FROM Clients " +
            " INNER JOIN Autentification ON Autentification.UserID = Clients.UserID" +
            " WHERE Autentification.Password = CONVERT(varbinary(max), @STRING_VARB, 1) ";
                    SqlCommand cmd = new SqlCommand(query, sqlc);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Last_Name_textBox.Text = dr["Last_Name"].ToString();
                        First_Name_textBox.Text = dr["First_Name"].ToString();
                        Patronym_textBox.Text = dr["Patronym"].ToString();
                        Phone_number_textBox.Text = dr["Phone_number"].ToString();
                        string temp = dr["Birthdate"].ToString();
                        Birthday_textBox.Text = temp.Remove(10, 8);
                        Passport_textBox.Text = dr["Passport_number"].ToString();
                        Permanent_living_location_textBox.Text = dr["Permanent_living_location"].ToString();
                    }
                    else
                    {
                        Last_Name_textBox.Text = "";
                        First_Name_textBox.Text = "";
                        Patronym_textBox.Text = "";
                        Phone_number_textBox.Text = "";
                        Birthday_textBox.Text = "";
                        Passport_textBox.Text = "";
                        Permanent_living_location_textBox.Text = "";
                    }
                    sqlc.Close();
                }
                catch (Exception MyMessage)
                {
                    MessageBox.Show(MyMessage.Message.ToString());
                    sqlc.Close();
                }
            }
            
            if (tabControl1.SelectedTab == Rooms_Info_tab)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Rooms_with_statuses". При необходимости она может быть перемещена или удалена.
                this.rooms_with_statusesTableAdapter.Fill(this.hotelDataSet.Rooms_with_statuses);
                if (this.Perm != "1" && this.Perm != "2")
                    Rooms_chng_tbl_button.Hide();
            }
            
            if (tabControl1.SelectedTab == Spec_services_tab)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Services". При необходимости она может быть перемещена или удалена.
                this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
                if (this.Perm != "1" && this.Perm != "2")
                    Spec_service_chng_tbl_button.Hide();
            }
            
            if (tabControl1.SelectedTab == Pending_payment_tab)
            {
                try 
                {
                    if (this.Perm != "1" && this.Perm != "2")
                        Very_Secret_And_Cool_button.Hide();
                    if (sqlc.State != System.Data.ConnectionState.Open)
                    {
                        sqlc.Open();
                    }
                    string query = "SELECT Clients.Last_name, Clients.Name AS First_name, Clients.Patronym, Rooms.Room_number, Settlement.Date_of_settlement, Settlement.Part, Rooms.Price FROM Settlement" +
                        " INNER JOIN Clients ON Clients.ClientID = Settlement.ClientID" +
                        " INNER JOIN Autentification ON Autentification.UserID = Clients.UserID" +
                        " INNER JOIN Rooms ON Rooms.RoomID = Settlement.RoomID" +
                        " WHERE Autentification.Password = CONVERT(varbinary(max), '" + HashedPass + "', 1) AND Settlement.Date_of_departure IS NULL";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(query, sqlc);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);
                    Your_Rooms_dataGridView.DataSource = dtbl;
                    sqlc.Close();
                    string query2 = "SELECT Clients.Last_name, Clients.Name AS First_name, Clients.Patronym, Rooms.Room_number, Orders.Date AS Order_Date, Services.Service_name, Orders.Amount, Services.Price FROM Settlement" +
" INNER JOIN Clients ON Clients.ClientID = Settlement.ClientID" +
" INNER JOIN Autentification ON Autentification.UserID = Clients.UserID" +
" INNER JOIN Rooms ON Rooms.RoomID = Settlement.RoomID" +
" INNER JOIN Orders ON Orders.SettlementID = Settlement.SettlementID" +
" INNER JOIN Services ON Services.ServiceID = Orders.ServiceID" +
" WHERE Autentification.Password = CONVERT(varbinary(max), '" + HashedPass + "', 1) AND Settlement.Date_of_departure IS NULL";
                    SqlDataAdapter sqlDA2 = new SqlDataAdapter(query2, sqlc);
                    DataTable dtbl2 = new DataTable();
                    sqlDA2.Fill(dtbl2);
                    Your_Services_dataGridView.DataSource = dtbl2;
                }
                catch(Exception MyMessage)
                {
                    MessageBox.Show(MyMessage.Message.ToString());
                    sqlc.Close();
                }
            }
            
            if (tabControl1.SelectedTab == Shedule_for_staff_tab)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Shedule_With_Names". При необходимости она может быть перемещена или удалена.
                this.shedule_With_NamesTableAdapter.Fill(this.hotelDataSet.Shedule_With_Names);
                if (this.Perm != "1" && this.Perm != "2")
                    Shedule_chng_tbl_button.Hide();
            }
        }

        private void Change_Your_Data_Button_Click(object sender, EventArgs e)
        {
            Change_Your_Data cyd = new Change_Your_Data(HashedPass, Perm);
            cyd.Owner = this;
            cyd.ShowDialog();
        }

        // кнопки для комнат
        private void Rooms_chng_tbl_button_Click(object sender, EventArgs e)
        {
            Rooms_admin ra = new Rooms_admin(this.HashedPass);
            this.Hide();
            ra.Owner = this;
            ra.ShowDialog();
            this.rooms_with_statusesTableAdapter.Fill(this.hotelDataSet.Rooms_with_statuses);
        }

        private void Settlement_time_button_Click(object sender, EventArgs e)
        {
            Get_A_Room gar = new Get_A_Room(this.HashedPass);
            this.Hide();
            gar.Owner = this;
            gar.ShowDialog();
            this.rooms_with_statusesTableAdapter.Fill(this.hotelDataSet.Rooms_with_statuses);
        }

        // кнопки для услуг
        private void Gib_me_service_Click(object sender, EventArgs e)
        {
            Make_A_Request mar = new Make_A_Request(this.HashedPass);
            this.Hide();
            mar.Owner = this;
            mar.ShowDialog();
            this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
        }

        private void Spec_service_chng_tbl_button_Click(object sender, EventArgs e)
        {
            Special_services_admn ssa = new Special_services_admn(this.HashedPass);
            this.Hide();
            ssa.Owner = this;
            ssa.ShowDialog();
            this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
        }

        // кнопки в разделе оплаты
        private void Very_Secret_And_Cool_button_Click(object sender, EventArgs e)
        {
            Secret_And_Cool_Admin SACA = new Secret_And_Cool_Admin(this.HashedPass, this.Perm);
            this.Hide();
            SACA.Owner = this;
            SACA.ShowDialog();
        }

        // кнопки для расписания
        private void Shedule_chng_tbl_button_Click(object sender, EventArgs e)
        {
            Shedule_admin sa = new Shedule_admin(this.HashedPass);
            this.Hide();
            sa.Owner = this;
            sa.ShowDialog();
            this.shedule_With_NamesTableAdapter.Fill(this.hotelDataSet.Shedule_With_Names);
        }

        // кнопки "назад"
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Back_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Back_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Back_button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Back_button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Your_Personal_Space_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                Owner.Show();
        }
    }
}
