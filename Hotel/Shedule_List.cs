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
    public partial class Shedule_list : Form
    {
        public Shedule_list()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
        private void Shedule_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Button)
            { }
            else
                if (Owner != null)
                    Owner.Show();
        }

        private void Shedule_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Shedule_With_Names". При необходимости она может быть перемещена или удалена.
            this.shedule_With_NamesTableAdapter.Fill(this.hotelDataSet.Shedule_With_Names);

        }
    }
}
