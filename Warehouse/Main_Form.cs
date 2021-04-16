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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            register_client.Click += new EventHandler(this.register);
            update_client.Click += new EventHandler(this.update);
            delete_client.Click += new EventHandler(this.delete);
            store_good.Click += new EventHandler(this.store);
            update_good.Click += new EventHandler(this.updateGood);
            Checkout_good.Click += new EventHandler(this.check);
            delete_good.Click += new EventHandler(this.del);
            create_cube.Click += new EventHandler(this.create);
            update_cube.Click += new EventHandler(this.date);
            delete_cube.Click += new EventHandler(this.cube);
            btnExit.Click += new EventHandler(this.exit);
    }
        private void register(object sender, EventArgs e)
        {
            var form = new Client_Registration();
            this.Hide();
            form.Show();
        }

        private void update_client_Click(object sender, EventArgs e)
        {

        }
        private void update(object sender, EventArgs e)
        {
            var form1 = new Update_Client();
            this.Hide();
            form1.Show();
        }
        private void updateGood(object sender, EventArgs e)
        {
            var form10 = new Good_update_form();
            this.Hide();
            form10.Show();
        }
        private void delete(object sender, EventArgs e)
        {
            var form2 = new Delete_Client();
            this.Hide();
            form2.Show();
        }

        private void store_good_Click(object sender, EventArgs e)
        {

        }
        private void store(object sender, EventArgs e)
        {
            var form3 = new Good_record_form();
            this.Hide();
            form3.Show();
        }

        private void Checkout_good_Click(object sender, EventArgs e)
        {

        }
        private void check(object sender, EventArgs e)
        {
            var form4 = new Good_checkout_form();
            this.Hide();
            form4.Show();
        }
        private void up(object sender, EventArgs e)
        {
            var form5 = new Good_record_form();
            this.Hide();
            form5.Show();
        }

        private void delete_good_Click(object sender, EventArgs e)
        {

        }
        private void del(object sender, EventArgs e)
        {
            var form6 = new Delete_Goods();
            this.Hide();
            form6.Show();
        }

        private void create_cube_Click(object sender, EventArgs e)
        {

        }
        private void create(object sender, EventArgs e)
        {
            var form7 = new Create_Cube();
            this.Hide();
            form7.Show();
        }

        private void update_cube_Click(object sender, EventArgs e)
        {

        }
        private void date(object sender, EventArgs e)
        {
            var form8 = new Update_Cube();
            this.Hide();
            form8.Show();
        }

        private void delete_cube_Click(object sender, EventArgs e)
        {

        }
        private void cube(object sender, EventArgs e)
        {
            var form9 = new Delete_Cube();
            this.Hide();
            form9.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        private void exit(object sender, EventArgs e)
        {
            this.Close();
         }
    }
}
