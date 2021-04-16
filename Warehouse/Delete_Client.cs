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
    public partial class Delete_Client : Form
    {
        public Delete_Client()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        { 
            var form = new Main_Form();
            this.Hide();
            form.Show();
            
        }

        private void client_id_TextChanged(object sender, EventArgs e)
        {
            
        }
      
    }
}
