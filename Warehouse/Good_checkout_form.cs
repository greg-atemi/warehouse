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
    public partial class Good_checkout_form : Form
    {
        public Good_checkout_form()
        {
            InitializeComponent();
            btn_back.Click += new EventHandler(this.Back);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
        private void Back(object sender, EventArgs e)
        {
            var form = new Good_record_form();
            this.Hide();
            form.Show();
        }

        private void btn_release_Click(object sender, EventArgs e)
        {
            if (name.Text == string.Empty)
                Err.SetError(name, "Name cannot be null!!");
            else
                Err.SetError(name, "");
            if (cube_id.Text == string.Empty)
                Err.SetError(cube_id, "Cube ID cannot be null!!");
            else
                Err.SetError(cube_id, "");
            if (good_id.Text == string.Empty)
                Err.SetError(good_id, "Cube ID cannot be null!!");
            else
                Err.SetError(good_id, "");
            if (client_id.Text == string.Empty)
                Err.SetError(client_id, "Client ID cannot be null!!");
            else
                Err.SetError(client_id, "");
            if (received_date.Text == string.Empty)
                Err.SetError(received_date, "Received date cannot be null!!");
            else
                Err.SetError(received_date, "");
            if (released_date.Text == string.Empty)
                Err.SetError(released_date, "Released date cannot be null!!");
            else
                Err.SetError(released_date, "");
        }

        private void good_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
