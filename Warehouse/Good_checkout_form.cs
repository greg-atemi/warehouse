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

            btn_back.Click += new EventHandler(this.back);

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

        private void Good_checkout_form_Load(object sender, EventArgs e)
        {

        }
    }
}
