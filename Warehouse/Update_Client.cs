using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Update_Client : Form
    {
        public Update_Client()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }

        private void get_email_Click(object sender, EventArgs e)
        {
            var client = Client.GetWithEmail(email.Text);
            name.Text = client.Name;
            phone_number.Text = client.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var client = new Client(name.Text, email.Text, phone_number.Text);
            client.Update();
        }
    }
}
