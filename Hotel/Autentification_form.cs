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
    public partial class Autentification_form : Form
    {
        public Autentification_form()
        {
            InitializeComponent();
        }

        private void Autentification_form_Load(object sender, EventArgs e)
        { }

        private void Entrance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entrance_form ef = new Entrance_form();
            ef.Back_to_aut = this;
            ef.ShowDialog();
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_form rf = new Registration_form();
            rf.Back_to_aut = this;
            rf.ShowDialog();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
