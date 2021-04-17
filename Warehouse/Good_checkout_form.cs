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
        
        static Good good = null;
        public Good_checkout_form()
        {
            InitializeComponent();
            btn_back.Click += new EventHandler(this.back);
            released_date.Format = DateTimePickerFormat.Custom;
            released_date.CustomFormat = "dd MM yyyy hh:mm";
            released_date.MaxDate = DateTime.Now;
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

            try
            {
                good.ReleasedDate = released_date.Value;
                good.Update();
                MessageBox.Show("Good checked out successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }

        private void good_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Good_checkout_form_Load(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                good = Good.GetWithId(int.Parse(good_id.Text));
                name.Text = good.Name;
                cube_id.Text = good.CubeId.ToString();
                client_id.Text = good.ClientId.ToString();
                received_date.Text = good.ReceivedDate.ToString();
                description.Text = good.Description;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
