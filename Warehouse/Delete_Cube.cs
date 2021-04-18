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
    public partial class Delete_Cube : Form
    {
        public Delete_Cube()
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
            
            try
            {
                if (cube_id.Text == string.Empty)
                {
                    Err.SetError(cube_id, "cube_id cannot be null!!");
                    throw new Exception("cube_id cannot be null!!");
                }
                else
                    Err.SetError(cube_id, "");
                var cube = Cube.GetWithId(int.Parse(cube_id.Text));
                cube.Delete();
                MessageBox.Show("Cube deleted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
