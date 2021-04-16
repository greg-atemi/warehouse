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
    public partial class Good_record_form : Form
    {
        public Good_record_form()
        {
            InitializeComponent();
            cube_id.DropDownStyle = ComboBoxStyle.DropDownList;
            client_id.DropDownStyle = ComboBoxStyle.DropDownList;
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            recieved_date.MaxDate = DateTime.Now;
            btn_back.Click += new EventHandler(this.back);
            name.KeyPress += new KeyPressEventHandler(this.InputValidator);

        }

        private void Good_record_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            if (name.Text == string.Empty)
                Err.SetError(name, "Name cannot be null!!");
            else
                Err.SetError(name, "");
            if (cube_id.Text == string.Empty)
                Err.SetError(cube_id, "Cube ID cannot be null!!");
            else
                Err.SetError(cube_id, "");
            if (client_id.Text == string.Empty)
                Err.SetError(client_id, "Client ID cannot be null!!");
            else
                Err.SetError(client_id, "");
            if (recieved_date.Text == string.Empty)
                Err.SetError(recieved_date, "Received date cannot be null!!");
            else
                Err.SetError(recieved_date, "");
        }
     

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputValidator(object sender, KeyPressEventArgs e)
        {
            TextBox text;
            if (sender is TextBox)
            {
                text = (TextBox)sender;
                if (text.Name == name.Name)
                {
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
                        e.Handled = false;
                    else if (e.KeyChar == ' ')
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }
    }
}

