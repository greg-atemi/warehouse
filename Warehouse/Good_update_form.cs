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
    public partial class Good_update_form : Form
    {
        private List<Client> clients = Client.GetAll();
        private List<Cube> cubes = Cube.GetAll();

        static Good good = null;

        public Good_update_form()
        {
            InitializeComponent();
            cube_id_current.ReadOnly = true;
            cube_id_transfer_to.DropDownStyle = ComboBoxStyle.DropDownList;
            client_email.DropDownStyle = ComboBoxStyle.DropDownList;
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            recieved_date.MaxDate = DateTime.Now;
            btn_back.Click += new EventHandler(this.back);
            button1.Click += new EventHandler(this.button1_Click);
            foreach (var client in clients)
            {
                client_email.Items.Add(client.Email);
            }
        }

        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var cubeId = cube_id_transfer_to.Text.Split('.')[0];
                var formCubeId = int.Parse(cubeId);
                if (good.CubeId != formCubeId)
                {
                    var cub = Cube.GetWithId(formCubeId);
                    if (cub.Occupied)
                    {
                        throw new Exception("Cube occupied please select another cube");
                    }

                    cub.Occupied = true;
                    var cub2 = Cube.GetWithId(good.CubeId);
                    cub2.Occupied = false;
                    cub.Update();
                    cub2.Update();
                }

                /*
                var cubeId = cube_id_current.Text;
                good.CubeId = int.Parse(cubeId);
                */
                good.Name = name.Text;
                good.Id = (int.Parse(good_id.Text));
                good.CubeId = (int.Parse(cubeId));
                good.ClientId = client_email.Text;
                good.ReceivedDate = recieved_date.Value;
                good.Description = description.Text;
                good.Update();
                MessageBox.Show("Good updated successfully.");
                name.Text = "";
                good_id.Text = "";
                cube_id_current.Text = "";
                cube_id_transfer_to.SelectedIndex = -1;
                client_email.SelectedIndex = -1;
                recieved_date.Text = "";
                description.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cube_id_transfer_to.Items.Clear();
            try
            {
                foreach (var cube in cubes)
                {
                    if (!cube.Occupied)
                    {
                        cube_id_transfer_to.Items.Add(cube.Id + ". " + cube.Name);
                    }
                }

                good = Good.GetWithId(int.Parse(good_id.Text));
                var cube1 = cubes.Find(cubeLocal => cubeLocal.Id == good.CubeId);
                name.Text = good.Name;
                cube_id_current.Text = cube1.Name;
                client_email.Text = good.ClientId;
                recieved_date.Text = good.ReceivedDate.ToString();
                description.Text = good.Description;
                cube_id_transfer_to.Items.Add(cube1.Id + ". " + cube1.Name);
                
                cube_id_transfer_to.Text = cube1.Id + ". " + cube1.Name;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}