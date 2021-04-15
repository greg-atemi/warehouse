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
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            btn_back.Click += new EventHandler(this.Back);
            name.KeyPress += new KeyPressEventHandler(this.InputValidator);
        }

        private void Good_record_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {

        }
    }
}
