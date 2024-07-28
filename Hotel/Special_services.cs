using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Special_services : Form
    {
        public Special_services(string HashedPass, string Perm)
        {
            InitializeComponent();
            this.Perm = Perm;
            this.HashedPass = HashedPass;
        }

        private void Special_services_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.hotelDataSet.Services);
            if (this.Perm != "1" && this.Perm != "2")
                Spec_service_chng_tbl_button.Hide();
        }

       
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Special_services_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
            {
                if (Owner != null)
                    Owner.Show();
            }
        }

        private void Spec_service_chng_tbl_button_Click(object sender, EventArgs e)
        {
            Special_services_admn ssa = new Special_services_admn();
            this.Hide();
            ssa.Owner = this;
            ssa.ShowDialog();
        }

        private void Gib_me_service_Click(object sender, EventArgs e)
        {

        }
    }
}
