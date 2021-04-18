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
    public partial class Update_Cube : Form
    {
        public Update_Cube()
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

        private void get_name_Click(object sender, EventArgs e)
        {
            var cube = Cube.GetWithId(int.Parse(cube_id.Text));
            name.Text = cube.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (name.Text == string.Empty)
                Err.SetError(name, "Name cannot be null!!");
            else
                Err.SetError(name, "");
            if (cube_id.Text == string.Empty)
                Err.SetError(cube_id, "Cube ID cannot be null!!");
            else
                Err.SetError(cube_id, "");
            try
            {
                var cube = Cube.GetWithId(int.Parse(cube_id.Text));
                cube.Name = name.Text;
                cube.Update();
                name.Text = "";
                cube_id.Text = "";
                
                MessageBox.Show("Cube updated succesfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cube_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
