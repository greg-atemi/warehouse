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
            phone.KeyPress += new KeyPressEventHandler(this.InputValidator);
        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }
        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                var newClient = new Client(name.Text, email.Text, phone.Text);
                if (name.Text == string.Empty)
                    Err.SetError(name, "Name cannot be null!!");
                else
                    Err.SetError(name, "");
                if (email.Text == string.Empty)
                    Err.SetError(email, "email cannot be null!!");
                else
                    Err.SetError(email, "");
                if (phone.Text == string.Empty)
                    Err.SetError(phone, "phone cannot be null!!");
                else
                    Err.SetError(phone, "");

                if (name.Text == String.Empty || email.Text == String.Empty || phone.Text == String.Empty)
                {
                    throw new Exception("All fields must be filled!!");
                }
                newClient.Save();
                name.Text = "";
                email.Text = "";
                phone.Text = "";
                MessageBox.Show("Client registered succesfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InputValidator(object sender, KeyPressEventArgs e)
        {
            TextBox text;
            if (sender is TextBox)
            {
                text = (TextBox) sender;
                if (text.Text == phone.Text)
                {
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char) 8)
                        e.Handled = true;
                }
                /*if (text.Text == email.Text)
                {
                    if (e.KeyChar == '@' || e.KeyChar == '.')
                        e.Handled = true;
                    else
                        e.Handled = false;
                }*/
            }
        }
    }
}
