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
    public partial class Delete_Client : Form
    {
        public Delete_Client()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);
        }

        private void back(object sender, EventArgs e)
        { 
            var form = new Main_Form();
            this.Hide();
            form.Show();
            
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (client_id.Text == string.Empty)
                Err.SetError(client_id, "ID cannot be null!!");
            else
                Err.SetError(client_id, "");
            try
            {
                var client = Client.GetWithEmail(client_id.Text);
                client.Delete();
                MessageBox.Show("Client deleted!");
            }
            catch
            {
                MessageBox.Show("Please fill in the id");
            }

        }
    }
}
