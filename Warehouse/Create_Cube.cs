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
    public partial class Create_Cube : Form
    {
        public Create_Cube()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);
        }

        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Close();
            form.Show();
        }

        private void createcube_Click(object sender, EventArgs e)
        {

            if (name.Text == string.Empty)
                Err.SetError(name, "Name cannot be null!!");
            else
                Err.SetError(name, "");

            try
            {
                var cube = new Cube(name.Text, false);
                cube.Save();

                MessageBox.Show("Cube created succesfully!");
            }
            catch
            {
                MessageBox.Show("Please enter name");
            }

            
        }
    }
}
