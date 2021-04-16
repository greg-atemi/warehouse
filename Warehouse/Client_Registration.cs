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
    public partial class Client_Registration : Form
    {
        public Client_Registration()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);

        }

        private void back_Click(object sender, EventArgs e)
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

        private void register_Click(object sender, EventArgs e)
        {
                var newClient = new Client(name.Text, email.Text);
                newClient.Save();
                //clear form
        }
    }
}
