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
            cube_id.DropDownStyle = ComboBoxStyle.DropDownList;
            client_email.DropDownStyle = ComboBoxStyle.DropDownList;
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            recieved_date.MaxDate = DateTime.Now;
            btn_back.Click += new EventHandler(this.back);
            name.KeyPress += new KeyPressEventHandler(this.InputValidator);
            foreach (var client in clients)
            {
                client_email.Items.Add(client.Email);
            }

            foreach (var cube in cubes)
            {
                cube_id.Items.Add(cube.Id + ". " + cube.Name);
            }
        }

        private void InputValidator(object sender, KeyPressEventArgs e)
        {
            TextBox text;
            if (sender is TextBox)
            {
                text = (TextBox) sender;
                if (text.Name == name.Name)
                {
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char) 8)
                        e.Handled = false;
                    else if (e.KeyChar == ' ')
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
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
                    var cubeId = cube_id.Text.Split('.')[0];
                    good.Name = name.Text;
                    good.CubeId = int.Parse(cubeId);
                    good.ClientId = client_email.Text;
                    good.ReceivedDate = recieved_date.Value;
                    good.Description = description.Text;
                    good.Update();
                    MessageBox.Show("Good updated successfully.");
                    name.Text = "";
                    cube_id.SelectedIndex = -1;
                    cube_id.SelectedIndex = -1;
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

            try
            {
                good = Good.GetWithId(int.Parse(good_id.Text));
                var cube1 = cubes.Find(cubeLocal => cubeLocal.Id == good.CubeId);
                
                name.Text = good.Name;
                cube_id.Text = cube1.Id + ". " + cube1.Name;
                client_email.Text = good.ClientId;
                recieved_date.Text = good.ReceivedDate.ToString();
                description.Text = good.Description;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
    }