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
            if (name.Text == string.Empty)
                Err.SetError(name, "Name cannot be null!!");
            else
                Err.SetError(name, "");
            if (email.Text == string.Empty)
                Err.SetError(email, "email cannot be null!!");
            else
                Err.SetError(email, "");
            if (phone_number.Text == string.Empty)
                Err.SetError(phone_number, "phone cannot be null!!");
            else
                Err.SetError(phone_number, "");
            try
            {
                if (name.Text == String.Empty || email.Text == String.Empty || phone_number.Text == String.Empty)
                {
                    throw new Exception("All fields must be filled!!");
                }
                var client = new Client(name.Text, email.Text, phone_number.Text);
                client.Update();
                MessageBox.Show("Client updated succesfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
