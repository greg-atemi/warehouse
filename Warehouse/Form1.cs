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

            btn_back.Click += new EventHandler(this.back);
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            name.KeyPress += new KeyPressEventHandler(this.InputValidator);

        }

        private void Good_record_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {

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
                    if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
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

