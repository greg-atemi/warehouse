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

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Close();
            form.Show();
        }

        private void createcube_Click(object sender, EventArgs e)
        {
            var cube = new Cube(name.Text, false);
            cube.Save();
        }
    }
}
